[Day 12]

Olá pessoal, como vocês estão? 😊


Hoje, continuando no estudo de Polimorfismo, estudei sobre os dois principais tipos de polimorfismo: o polimorfismo de sobrecarga e o de sobreposição.


O que é o polimorfismo de sobrecarga? O polimorfismo de sobrecarga é a ação de criar um método com o mesmo nome, porém com uma assinatura ou parâmetros diferentes. Por exemplo, se eu tenho uma classe Calculadora e um método Soma que recebe os parâmetros N1 e N2 e me retorna a soma desses dois números, e eu crio um outro método Soma que me retorna a soma de N1, N2 e N3, aqui ocorreu o polimorfismo de sobrecarga. Eu poderia até mudar o tipo de retorno desse método que contém o mesmo nome. Esse recurso é muito usado em construtores de classes, onde é feito um construtor padrão, e depois outro construtor recebendo os parâmetros que são necessários ➕.


Agora, temos outro tipo de polimorfismo, que também é muito usado: o polimorfismo de sobreposição. O polimorfismo de sobreposição é aquele em que o método é implementado na classe filha ou ganha uma nova implementação na classe filha. Assim como eu disse alguns dias atrás, em C# temos a palavra "virtual", que significa que esse método pode ser sobrescrito na classe filha usando a palavra "override" 🔄.
