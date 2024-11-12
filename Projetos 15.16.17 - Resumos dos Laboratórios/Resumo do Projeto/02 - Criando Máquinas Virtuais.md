## Criando Máquinas Virtuais no Azure

No Portal do Azure, na área de **Todos os Serviços**, é possível criar uma máquina virtual através do caminho: `Computação > Infrastructure as a Service > Máquinas Virtuais`, depois clicar no botão `➕Criar`. Isso exibe 3 opções:
- Máquina virtual do Azure
- Máquina virtual do Azure com uma configuração predefinida
- Mais VMs e soluções relacionadas

Ao clicar em **Máquina Virtual do Azure**, são exibidas diversas abas de opções para definir sobre a máquina virtual, como opções de disco, rede, gerenciamento, monitoramento, dentre outras.

Em cada opção, há um ícone de informação que pode ser clicado para ver uma explicação mais detalhada, muitas delas contendo um link que abre a documentação da Microsoft sobre aquele assunto no Azure.

Várias dessas opções afetam o custo final da criação e manutenção da máquina virtual, por isso é importante entender as opções e saber quais delas utilizar para cada situação.

### Valores do SLA

O SLA do Azure define 5 tipos de planos de disponibilidade, cada um com uma cobertura diferente:

|   SLA   | Downtime por Semana | Downtime por Mês | Downtime por Ano |
|---------|---------------------|------------------|------------------|
|   99%   |      1,68 hora      |     7,2 horas    |    3,65 dias     |
|  99,9%  |    10,1 minutos     |   43,2 minutos   |    8,76 horas    |
|  99,95% |      5 minutos      |   21,6 minutos   |    4,38 horas    |
|  99,99% |     1,01 minuto     |   4,32 minutos   |  52,56 minutos   |
| 99,999% |     6 segundos      |   25,9 segundos  |   5,26 minutos   |

Esses são os tempos de inatividade definidos como aceitáveis dentro do contrato.