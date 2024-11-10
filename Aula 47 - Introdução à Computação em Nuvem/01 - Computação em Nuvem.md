## Computação em Nuvem

### O que é Computação em Nuvem?

A computação em nuvem é o fornecimento de serviços de computação pela internet, habilitando invações rápidas, recursos flexíveis e economia de escala.

As empresas que trabalham com TI precisam ter um data center, uma sala que possui vários servidores. Antes da computação em nuvem, essa sala ficava dentro da empresa, com os servidores necessários para os sitemas da empresa funcionarem. Isso é chamado de um data center físico.  
Conforme a tecnologia avançou, e as empresas possuem sistemas cada vez maiores, são necessários mais computadores e data centers maiores para manterem o funcionamento desses sistemas, o que pode se tornar inviável para muitas empresas.

Para lidar com esse problema, surge a virtualização, que permite emular vários computadores dentro de um computador.  
Assim se iniciou a computação em nuvem, que consiste na virtualização de data centers feita por grandes empresas, como Google, Microsoft, Amazon, Oracle, dentre outras.  
A computação em nuvem consiste no fornecimento de serviços através de internet, sem a necessidade de uma empresa possuir servidores físicos.

A computação em nuvem permite criar recursos de forma muito rápida. Quando uma empresa precisa de um novo serviço ou de mais máquinas para um serviço, as empresas de infraestrutura em nuvem podem fornecê-los em poucos minutos.

Na computação em nuvem, os serviços são disponibilizados através da internet, e são cobrados conforme o seu uso.  
Uma empresa que contrata serviços em nuvem não precisa gastar com ambientes e computadores físicos, mas precisa pagar pelo uso do serviço.

### Modelos de Nuvem

#### Nuvem Privada

Uma nuvem privada é um ambiente de nuvem que possui sua arquitetura 100% dentro da empresa que o utiliza. A empresa possui uma estrutura de nuvem dentro de seu próprio data center.  
Em uma nuvem privada, a própria empresa dona do data center é responsável pela instalação, configuração, operação e manutenção de sua infraestrutura.  
Um serviço de nuvem privado não é fornecido a usuários de fora da empresa, sendo somente de uso interno.

#### Nuvem Pública

Uma nuvem pública é um ambiente de nuvem que é entregue a diversas empresas clientes por meio de um único provedor de nuvem. A empresa provedora do serviço possui um ou mais data centers com o objetivo de entregar infraestrutura de nuvem para outras empresas.  
Uma infraestrutura de nuvem pública não se limita a data centers físicos, ou mesmo a uma localidade, podendo ser fornecida para clientes de todo o mundo.

#### Nuvem Híbrida

A nuvem híbrida é um modelo que mistura os dois modelos anteiores. Nesse modelo, uma empresa possui a sua infraestrutura de nuvem privada, e contrata serviços de nuvem pública, podendo fazer os dois serviços se comunicarem entre si.

#### Movelo Multi-cloud

Um modelo multi-cloud é um modelo onde a empresa trabalha com diversos ambientes de cloud ao mesmo tempo, sendo tanto ambientes privados como públicos.

#### Comparação dos Modelos de Nuvem

- Nuvem Pública
    - Não requer nenhuma despesa para escalar verticalmente. Não há nenhum custo direto relacionado à compra de novos computadores para rodar os serviços.
    - Os aplicativos podem ser provisionados e desprovisionados rapidamente. As máquinas virtuais podem ser gerenciadas conforme a necessidade da empresa.
    - As organizações pagam apenas pelo que utilizam. O pagamento é feito por inscrição (por exemplo, mensalmente), mas somente pelo tempo que cada recurso for utilizado.
    - O provedor de serviços de nuvem é responsável por toda a parte da infraestrutura, como a compra e manutenção dos equipamentos e do espaço necessário para que eles funcionem.
- Nuvem Privada
    - A empresa deve arcar com as despesas de compra do hardware, além da manutenção dos equipamentos e das instalações necessárias.
    - As organizações têm controle total sobre os recursos e a segurança. Elas podem determinar quem tem acesso ao data center ou não.
    - As organizações são responsáveis pela manutenção e atualizações do hardware e software.
- Nuvem Híbrida
    - As organizações determinam onde executar os aplicativos. Elas possuem acesso tanto à sua nuvem privada, como à nuvem pública que elas contratam.
    - As organizações controlam a segurança, a conformidade e os requisitos legais. O provedor de nuvem fornece as ferramentas de segurança, mas a organização pode determinar como e quando utilizá-las.
    - Fornece a maior flexibilidade.

### Despesas

- Despesas de Capital (**CapEX**)
    - O gasto inicial de dinheiro em infraestrutura física. Ao adquirir um novo servidor, há vários custos envolvidos com a sua compra e instalação.
    - As despesas do CapEx têm um valor que se reduz com o tempo. A partir do momento que a empresa já possui uma infraestrutura, a despesa inicial já foi realizada, sendo necessários apenas custos relacionados à manutenção da infraestrutura.
- Despesas Operacionais (**OpEx**)
    - Despesas com produtos e serviços conforme necessário, pagamento conforme o uso. Essa despesa é consistente, sendo paga após um certo período (normalmente mensal).

#### Modelo Baseado em Consumo

Os provedores de serviços de nuvem utilizam um modelo de cobrança baseado no consumo, que define que os usuátios só pagam pelos recursos que consomem, durante o tempo que ele foi consumido.  
Se um serviço for usado por somente 10 dias, ao final do mês, o valor cobrado será referente a apenas 10 dias.

Benefícios desse modelo de cobrança:
- Melhor previsão de custos.
- Os recursos e serviços possuem preços individuais.
- A cobrança é feita com base no uso real do recurso.

## Criar uma Conta Gratuita no Microsoft Azure

Acessar o site do Microsoft Azure: `azure.microsoft.com`. Depois entrar na página de criação de conta, que pode ser acessada diretamente no link `azure.microsoft.com/pt-br/pricing/purchase-options/azure-account`.

Clicar no botão **Experimente Gratuitamente**.  
Isso abrirá a página de criação de conta. O primeiro passo é informar o e-mail, depois preencher os vários dados necessários: país, nome, endereço, telefone e CNPJ.  
Depois de todos os dados serem preenchidos, é necessário inserir um número de cartão de crédito, e será debitado um valor para confirmar o cartão (que será extornado em seguida).  
A conta gratuita pode ser usada por 30 dias, e fornece créditos de $200 para utilizar nos serviços da Azure.