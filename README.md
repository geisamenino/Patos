# Vantagens da Utilização do Padrão de Projeto Strategy no Problema dos Patos

Ao resolver o problema dos patos, nos deparamos com um cenário onde alguns patos não podem voar. Uma forma comum de resolução seria sobrescrever o método de voo usando `override` nas subclasses que não voam. Embora funcione, essa solução dificulta a manutenção: se surgirem vários patos que não voam e a regra precisar mudar, o código terá que ser alterado em cada uma dessas classes. O uso de `if/else` também não é o ideal, pois aumenta a complexidade desnecessariamente.

A melhor solução é o padrão de projeto **Strategy**, que substitui a herança pela composição. Criamos uma interface chamada `ModoVoo` com o método `voar()`. A classe-mãe `Pato` possui uma referência para essa interface, e as estratégias concretas (`NaoVoar`, `VoarComAsas`, etc.) implementam a interface com seus próprios comportamentos.

As principais vantagens dessa forma são:

* **Facilidade de manutenção:** Alterações em um modo de voo são feitas apenas na sua respectiva classe, sem afetar o restante do sistema.
* **Extensibilidade:** Novos modos de voo podem ser criados rapidamente sem modificar as classes de patos existentes.
* **Troca dinâmica de comportamento:** O método `setModoVoo` permite alterar a forma de voar de um pato em tempo de execução (por exemplo, fazendo um `PatoDeFerro` passar a voar com balão durante o programa).
