## Benefícios da Nuvem

#### Alta Disponibilidade

A disponibilidade de um sistema define quando aquele sistema está em funcionamento e pronto para uso, conhecido como *uptime*.  
Um sistema altamente disponível é um sistema que funciona por uma parcela alta de tempo, no qual os recursos podem ser acessados pelo máximo de tempo possível, independente de interrupções, falhas ou eventos que ocorram. A alta disponibilidade garante que o usuário tenha a melhor experiência ao utilizar o sistema, sem ter que lidar com tempo de indisponibilidade, ou *downtime*.  
Em serviços de nuvem, a garantia de alta disponibilidade é responsabilidade do provedor da nuvem, sendo definida através do SLA (Service Level Agreement). O SLA define quanto tempo de garantia de disponibilidade o provedor da nuvem pode oferecer.  
Quanto maior for a necessidade de disponibilidade do serviço, maior será o custo e a dificuldade para manter essa disponibilidade. Serviços de alta disponibilidade precisam de cuidados como geração de energia, backups, redundância do serviço (ter mais de uma instância rodando, para caso um dê problema, o outro possa continuar), dentre outros.

No Azure, o SLA trata a disponibilidade com porcentagem, definindo qual parcela do tempo contratado o serviço tem garantia de estar disponível. Os contratos mais comuns são de:
- 99% do tempo / 1% de indisponibilidade
- 99.9% do tempo / 0.1% de indisponibilidade
- 99.95% do tempo / 0.05% de indisponibilidade
- 99.99% do tempo / 0.01% de indisponibilidade
Em cada um destes contratos, há um certo tempo em que o serviço pode estar indisponível e ainda estar dentro do acordo de garantia. No caso de 99% do tempo, por exemplo, o serviço pode ficar indisponível por, no máximo, 7.2 horas por mês.  
Se a disponibilidade contratada não for entregue pelo provedor de nuvem, o cliente deve ser resarcido de alguma forma. No caso do Azure, isso é feito com créditos para utilizar nos serviços.

#### Escalabilidade

A escalabilidade se refere à capacidade de ums sitema ter seus recursos ajustados para atender à demanda por seus serviços. Conforme a demnada pelo serviço aumenta, o sistema deve ser capaz de adicionar mais recursos para mantê-los disponíveis.

Um sistema escalável é um sistema que possui essa capacidade de aumentar os seus recursos. Por exemplo, caso um servidor tenha pouco espaço de armazenamento, e os usuários necessitem armazenar mais arquivos, deve ser possível adicionar mais discos (por exemplo, um HD a mais) para suprir essa demanda por armazenamento. Os demais recursos do servidor, como memória, processador e sistema operacional, não precisam ser alterados, pois ele ainda atende a demanda.

A virtualização da nuvem permite escalar os recursos com facilidade, adequando-os à demanda do sistema a cada momento. Quando a demanda aumentar, são alocados mais recursos, e quando diminuir, os recursos são reduzidos.

A escalabilidade também permite reduzir custos, uma vez que os recursos só aumentam quando a demanda necessita. Assim não há desperdício de recursos.

#### Elasticidade

A elasticidade permite expandir os recursos implanatados, automaticamente ou manualmente, para lidar com um aumento muito repentino e significativo na demanda por um serviço. Da mesma forma, também é possível reduzir os recursos caso haja uma queda significativa na demanda.  

A elasticidade lida com a capacidade do sistema de se adaptar a mudanças repentinas, de forma rápida.

#### Confiabilidade

A confiabilidade é uma questão muito ligada à resiliência do sistema, a sua capacidade de se recuperar de falhas e continuar funcionando.

Devido à nuvem possuir um design decentralizado, a infraestrutura naturalmente pode se tornar resiliente e confiável. É possível ter recursos implantados em várias regiões do mundo, assim garantindo que o sistema possa se recuperar de qualquer falha.

#### Previsibilidade

A previsibilidade está relacionada à confiança, seja através do desempenho ou do custo. É preciso ter confiança no ambiente da nuvem, que o provedor irá ofertar os melhores recursos, e que o cliente terá o apoio necessário na implantação da nuvem e na utilização dos recursos.

#### Segurança

A nuvem oferece diversas ferramentas de segurança para atender às necessidades dos clientes. Porém, muitas delas devem ser implementadas pelo cliente.  
A responsabilidade de definir as políticas de segurança é do próprio cliente que contrata o serviço de nuvem, para garantir que essas regras se adequam às necessidades da organização.

O provedor de nuvem é responsável pelos recursos físicos, mas os mecanismos de segurança dos sistemas operacionais e softwares utilizados podem ser definidos pelo cliente.  
Caso o cliente queira ter o controle máximo da segurança, ele será capaz de gerenciar inteiramente os sistemas operacionais e softwares instalados, incluindo a aplicação de patches e manutenção.  
Caso o controle máximo não seja necessário, é possível que o provedor de nuvem trate da implantação dessas ferramentas, definindo as melhores estratégias.

#### Governança

A governança define os padrões de gerenciamento dos recursos de nuvem contratados pela empresa.

A auditoria em nuvem ajuda a sinalizar qualquer recurso que está fora de conformidade com os padrões definidos pela empresa, e oferece estratégias para mitigação do problema. Com ela é possível ver quem fez cada ação e o acesso que cada usuário tem ao sistema.

A governança está muito ligada à segurança, mas no âmbito da gestão empresarial. Ela permite ter regras para adequar os sistemas ao ramo da empresa que está utilizando o serviço.  
Dependendo do modelo operacional, é possível que patches de software e atualizações sejam aplicados automaticamente.  
Ao estabelecer a presenã de governança o mais cedo possível, é possível manter a nuvem da empresa atualizada, protegida e bem gerenciada.

#### Gerenciabilidade

Um dos principais benefícios da nuvem são as opções de capacidade de gerenciamento. Ela facilita o gerenciamento para os usuários da nuvem.  
A nuvem permite fazer várias ações de gerenciamento através das ferramentas mais adequadas para cada usuário, seja pelo portal da nuvem, seja por linha de comando, pelo powershell, por chamadas de API, dentre outros modos.