## Conceitos Básicos de Mensageria

### Mensagens e Eventos

A **mensagem** é composta por um pacote de dados brutos. Eles podem estar em formatos como XML, JSON, Bytes, dentre outros.  
O que define o formato da mensagem é um contrato entre o consumidor e o produtor da mensagem. Eles precisam trabalhar juntos para que a mensagem possa ser consumida corretamente.

Para fazer transmissão de mensagens pelo Azure, é usado o Azure Service Bus. Ele é uma estrutura auto-gerenciável que da suporte ao processo de transmissão de mensagens, usando filas e tópicos.

Um **evento** é uma notificação de uma condição ou alteração de estado em um sistema. O evento não carrega os dados brutos, ele é apenas uma notificação.  
Por exemplo, ao criar um arquivo, um evento notifica os sistemas que esse arquivo foi criado, mas não contém o conteúdo do arquivo.

A mensagem possui uma expectativa sobre como o consumidor irá manipulá-la. O evento não tem expectativa sobre ele, o consumidor decide o que fazer com a notificação.

### Filas

As mensagens são enviadas e recebidas a partir de filas. As filas armazenam mensagens até que o aplicativo que a recebe esteja disponível para recebê-las e processá-las.

As filas podem ser usadas para:
- **Transferência de dados**: O produtor cria um dado, e envia para outras aplicações através da fila, para que elas possam utilizá-lo.
- **Separação de aplicativos**: Também conhecido como "desacoplamento". O uso de filas permite que duas aplicações se comuniquem de maneira assíncrona, permitindo que as aplicações possam estar online em momentos diferentes e ainda conseguirem se comunicar.
- **Amortecimento de carga**: As filas permitem que aplicações que funcionam juntas trabalhem com volumes diferentes de cargas. Uma aplicação que está escalada a um nível mais alto pode postar várias mensagens de uma vez, enquanto uma outra aplicação consome essas mensagens de forma mais lenta, em seu próprio ritmo.
- **Balanceamento de carga**: As filas também permitem que diversas aplicações diferentes acessem as mensagens na mesma fila, assim balanceando a carga entre aplicações.

### Tópicos

Os tópicos são semelhantes às filas. A principal diferença entre eles é que os tópicos podem ter várias assinaturas independentes, ou seja, vários serviços recebendo a mensagem ao mesmo tempo.  
O Service Bus é o responsável por gerenciar o consumo de mensagens por vários receptores.

### Event Grid

O Event Grid é uma ferramenta da Azure que oferece suporte a uma arquitetura orientada a eventos. Ele utiliza um modelo de Pub/Sub, onde os remetentes publicam os eventos, e os inscritos assinam os tópicos no Event Grid para receber os eventos. Quem posta os eventos não sabe quem está consumindo esses eventos.

Os eventos funcionam com base em assinaturas, de forma similar ao tópico.

## Trabalhando com Mensagens

### Criar um Service Bus no Azure

- No portal do Azure, acessar a opção **Barramento de Serviço** (Service Bus).
- Clicar em **Adicionar**.
- Escolher a assinatura e o grupo de recursos.
- Preencher os dados do namespace:
    - Nome
    - Localização
    - Tipo de preço
- Finalizar a criação do barramento.

### Criar uma Fila

- Entrar no barramento de Serviço.
- Entrar na página de **Filas**.
- Criar uma fila nova.
- Preencher os dados da fila: 
    - Nome
    - Tamanho máximo: O tamanho máximo que a fila pode suportar.
    - Contagem máxima de entregas: Quantas vezes a fila vai tentar reenviar uma mensagem em caso de falha.
    - Vida útil da mensagem: Quanto tempo a mensagem vai ficar na fila esperando para ser consumida. Após a mensagem expirar, ela pode ser excluída, ou ir para uma *Fila de mensagens mortas*.
    - Duração do bloqueio: Quanto tempo uma aplicação pode levar para consumir uma mensagem. Quando esse tempo expira, a mensagem volta para a fila para ser reenviada.
- Definir as opções adicionais da fila.
    - Excluir a fila automaticamente em caso de inatividade.
    - Habilitar detecção de duplicidade.
    - Habilitar *fila de mensagens mortas* para mensagens expiradas.
    - Habilitar o particionamento: Particinar a fila no Azure para melhorar o desempenho.
    - Habilitar sessões: Sessões permitem trabalhar com ordem de entrega. Ela permite que algumas mensagens sejam configuradas com uma ordem, onde a primeira mensagem da ordem deve ser consumida antes da segunda, e assim por diante.
    - Encaminhar mensagens para a fila ou tópico.
- Finalizar a criação da fila.

### Criar um Tópico

- Entrar no barramento de Serviço.
- Entrar na página de **Tópicos**.
- Criar um tópico novo.
- Preencher os dados do tópico: 
    - Nome
    - Tamanho máximo: O tamanho máximo que o tópico pode suportar.
    - Vida útil da mensagem: Quanto tempo a mensagem vai ficar no tópico esperando para ser consumida.
- Definir as opções adicionais do tópico.
    - Excluir o tópico automaticamente em caso de inatividade.
    - Habilitar detecção de duplicidade.
    - Habilitar o particionamento: Particinar o tópico no Azure para melhorar o desempenho.
- Finalizar a criação do tópico.

#### Criar uma Assinatura dentro do tópico

- Entrar no tópico.
- Acessar a página **Assinaturas**
- Criar uma nova assinatura.
- Preencher as opções da assinatura:
    - Nome
    - Contagem máxima de entregas: Quantas vezes o tópico vai tentar reenviar uma mensagem em caso de falha.
    - Tempo para excluir após ficar ocioso.
    - Encaminhar mensagens para a fila ou tópico.
    - Habilitar sessões: Sessões permitem trabalhar com ordem de entrega. Ela permite que algumas mensagens sejam configuradas com uma ordem, onde a primeira mensagem da ordem deve ser consumida antes da segunda, e assim por diante.
    - Vida útil da mensagem: Quanto tempo a mensagem vai ficar no tópico esperando para ser consumida.
    - Habilitar *fila de mensagens mortas* para mensagens expiradas.
    - Mover mensagens que causam exceções para a *fila de mensagens mortas*.
- Finalizar a criação do tópico.

### Criar uma Chave de Acesso

- Dentro do barramento de serviço, escolher a opção **Políticas de Acesso Compatilhado**.
- Criar uma nova **Chave de Acesso**.
- Escolher a permissão da chave:
    - Gerenciar
    - Enviar
    - Ouvir

### Criar um projeto no Visual Studio

- Criar um projeto console.
- Adicionar um pacote do NuGet para consumir mensagens de um Service Bus: `Microsoft.Azure.ServiceBus`.
- Criar um HostBuilder no `Program.cs`, que será responsável por adicionar os serviços na aplicação.

#### Criar o Serviço de Consumo de Filas

- Criar uma nova Classe `ConsumidorFila`, que herda de `BackgroundService`.
- Adicionar um construtor que instancia uma `QueueClient`:
```
private readonly QueueClient _client;

public ConsumidorFila()
{
    _client = new QueueClient("ConnectionString", "fila", ReceiveMode.PeekLock);
    Console.WriteLine("Iniciando a leitura da fila no ServiceBus...");
}
```
- Adicionar o método de receber as mensagens:
```
protected override async Task ExecuteAsync(CancellationToken stoppingToken)
{
    while (!stoppingToken.IsCancellationRequested)
    {
        await Task.Run(() =>
        {
            _client.RegisterMessageHandler(ProcessarMensagem,
                new MessageHandlerOptions(ProcessarErro)
                {
                    MaxConcurrentCalls = 1,
                    AutoComplete = false
                }
            );
        });
    }
}
```
- Adicionar também o método de parar de receber mensagens, que fecha a conexão com a fila:
```
public override async Task StopAsync(CancellationToken stoppingToken)
{
    await _client.CloseAsync();
    Console.WriteLine("Finalizando conexão com o Azure Service");
}
```
- Adicionar o método de processar as mensagens recebidas:
```
private async Task ProcessarMensagem(Message message, CancellationToken token)
{
    var corpo = Encoding.UTF8.GetString(message.Body);

    Console.WriteLine("[Nova Mensagem Recebida na fila] " + corpo);

    await _client.CompleteAsync(message.SystemProperties.LockToken);
}
```
- Por fim, adicionar o método de processar os erros:
```
private Task ProcessarErro(ExceptionReceivedEventArgs e)
{
    Console.WriteLine("[Erro] " + e.Exception.GetType().FullName + " " + e.Exception.Message);
    return Task.CompletedTask;
}
```

#### Criar um Serviço de Produção em Fila

- Criar uma classe `ProdutorFila`.
- Adicionar um construtor que também instancia uma `QueueClient`:
```
public ProdutorFila()
{
    _client = new QueueClient("ConnectionString", "fila");
}
```
- Adicionar um método de produzir mensagens para a fila:
```
public async Task ProduzirMensagem()
{
    try
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Enviando mensagem: " + i);
            await _client.SendAsync(new Message(Encoding.UTF8.GetBytes("Número " + i)));
        }

        Console.WriteLine("Concluido o envio das mensagens");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro: {ex.GetType().FullName} | " + $"Mensagem: {ex.Message}");
    }
    finally
    {
        if (_client != null)
        {
            await _client.CloseAsync();
            Console.WriteLine("Finalizando conexão com ServiceBus");
        }
    }
}
```

#### Criar um Serviço de Produção de Mensagens em Agendamento

- Criar uma classe `ProdutorFilaAgendamento`, feita de forma igual à anterior, de produção de mensagens.
- No método de produzir mensagens, remover a linha:
```
await _client.SendAsync(new Message(Encoding.UTF8.GetBytes("Número " + i)));
```
- Colocar em seu lugar:
```
await _client.ScheduleMessageAsync(new Message(Encoding.UTF8.GetBytes("Número " + i)), DateTime.Now.AddMinutes(1));
```

#### Criar um Serviço de Consumo de Mensagens na Fila de Mensagens mortas

- Criar uma nova Classe `ConsumidorFilaMorta`, desenvolvida igual à classe `ConsumidorFila`.
- No construtor, definir a fila de mensagens mortas, em vez da fila padrão, para o consumo:
```
public ConsumidorFilaMorta()
{
    _client = new QueueClient("ConnectionString", "fila/$DeadLetterQueue", ReceiveMode.PeekLock);
    Console.WriteLine("Iniciando a leitura da fila no ServiceBus...");
}
```

#### Criar um Serviço de Produzir Mensagens em Tópico

- Criar uma classe `ProdutorTopico`, desenvolvida igual à classe `ProdutorFila`.
- No construtor da classe, criar uma instância de `TopicClient` em vez de `QueueClient`:
```
private readonly TopicClient _client;

public ProdutorTopico()
{
    _client = new TopicClient("ConnectionString", "topico");
}
```

#### Criar um Serviço de Consumir Mensagens em Tópico

- Criar uma classe `ConsumidorTopico`, desenvolvida igual à classe `ConsumidorFila`.
- No construtor, alterar para usar o tópico e a assinatura:
```
private readonly SubscriptionClient _client;
private readonly ILogger<ConsumidorTopico> _log;

public ConsumidorTopico(ILogger<ConsumidorTopico> log)
{
    _log = log;

    _client = new SubscriptionClient("ConnectionString", "topico", "assinatura");
    Console.WriteLine("Iniciando a leitura do topico no ServiceBus...");
}
```