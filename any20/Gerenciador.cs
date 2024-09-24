namespace any20
{
    public class Gerenciador
    {
        List<Questao> ListaQuestoes = new List<Questao>();
        List<int> ListaQuestoesRespondidas = new List<int>();
        Questao QuestaoCorrente;

        public Gerenciador(Label labelPerg, Button ButtonResposta1, Button ButtonResposta2, Button ButtonResposta3, Button ButtonResposta4, Button ButtonResposta5)
        {
            CriaPerguntas(labelPerg, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);

        }
        void CriaPerguntas(Label labelPerg, Button buttonResposta1, Button ButtonResposta2, Button ButtonResposta3, Button ButtonResposta4,Button ButtonResposta5)
        {
           var Q1 = new Questao();
Q1.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q1.Pergunta = "Qual é o maior planeta do Sistema Solar?";
Q1.Resposta1 = "Terra";
Q1.Resposta2 = "Júpiter";
Q1.Resposta3 = "Marte";
Q1.Resposta4 = "Saturno";
Q1.Resposta5 = "Vênus";
Q1.Respostacorreta = 2;

var Q2 = new Questao();
Q2.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q2.Pergunta = "Quem pintou a Mona Lisa?";
Q2.Resposta1 = "Michelangelo";
Q2.Resposta2 = "Vincent Van Gogh";
Q2.Resposta3 = "Leonardo da Vinci";
Q2.Resposta4 = "Pablo Picasso";
Q2.Resposta5 = "Claude Monet";
Q2.Respostacorreta = 3;

var Q3 = new Questao();
Q3.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q3.Pergunta = "Qual é o elemento químico representado pelo símbolo 'O'?";
Q3.Resposta1 = "Oxigênio";
Q3.Resposta2 = "Ouro";
Q3.Resposta3 = "Prata";
Q3.Resposta4 = "Ósmio";
Q3.Resposta5 = "Chumbo";
Q3.Respostacorreta = 1;

var Q4 = new Questao();
Q4.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q4.Pergunta = "Em qual país se encontra a Torre Eiffel?";
Q4.Resposta1 = "Inglaterra";
Q4.Resposta2 = "Alemanha";
Q4.Resposta3 = "França";
Q4.Resposta4 = "Itália";
Q4.Resposta5 = "Espanha";
Q4.Respostacorreta = 3;

var Q5 = new Questao();
Q5.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q5.Pergunta = "Qual o nome do cientista que formulou a teoria da relatividade?";
Q5.Resposta1 = "Isaac Newton";
Q5.Resposta2 = "Nikola Tesla";
Q5.Resposta3 = "Galileu Galilei";
Q5.Resposta4 = "Albert Einstein";
Q5.Resposta5 = "Marie Curie";
Q5.Respostacorreta = 4;

var Q100 = new Questao();
Q100.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q100.Pergunta = "Qual é o oceano mais profundo do mundo?";
Q100.Resposta1 = "Oceano Atlântico";
Q100.Resposta2 = "Oceano Índico";
Q100.Resposta3 = "Oceano Pacífico";
Q100.Resposta4 = "Oceano Ártico";
Q100.Resposta5 = "Oceano Antártico";
Q100.Respostacorreta = 3;

// Pergunta 1
var Q1 = new Questao();
Q1.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q1.Pergunta = "Qual é o maior planeta do Sistema Solar?";
Q1.Resposta1 = "Terra";
Q1.Resposta2 = "Júpiter";
Q1.Resposta3 = "Marte";
Q1.Resposta4 = "Saturno";
Q1.Resposta5 = "Vênus";
Q1.Respostacorreta = 2;

// Pergunta 2
var Q2 = new Questao();
Q2.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q2.Pergunta = "Quem pintou a Mona Lisa?";
Q2.Resposta1 = "Michelangelo";
Q2.Resposta2 = "Vincent Van Gogh";
Q2.Resposta3 = "Leonardo da Vinci";
Q2.Resposta4 = "Pablo Picasso";
Q2.Resposta5 = "Claude Monet";
Q2.Respostacorreta = 3;

// Pergunta 3
var Q3 = new Questao();
Q3.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q3.Pergunta = "Qual o país mais populoso do mundo?";
Q3.Resposta1 = "Estados Unidos";
Q3.Resposta2 = "Índia";
Q3.Resposta3 = "China";
Q3.Resposta4 = "Brasil";
Q3.Resposta5 = "Indonésia";
Q3.Respostacorreta = 3;

// Pergunta 4
var Q4 = new Questao();
Q4.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q4.Pergunta = "Qual é o elemento químico representado pelo símbolo 'H'?";
Q4.Resposta1 = "Hélio";
Q4.Resposta2 = "Hidrogênio";
Q4.Resposta3 = "Hafnio";
Q4.Resposta4 = "Hólmio";
Q4.Resposta5 = "Háfnio";
Q4.Respostacorreta = 2;

// Pergunta 5
var Q5 = new Questao();
Q5.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q5.Pergunta = "Qual é o menor país do mundo?";
Q5.Resposta1 = "Mônaco";
Q5.Resposta2 = "Malta";
Q5.Resposta3 = "Vaticano";
Q5.Resposta4 = "Liechtenstein";
Q5.Resposta5 = "Andorra";
Q5.Respostacorreta = 3;

// Pergunta 6
var Q6 = new Questao();
Q6.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q6.Pergunta = "Qual a capital do Brasil?";
Q6.Resposta1 = "São Paulo";
Q6.Resposta2 = "Rio de Janeiro";
Q6.Resposta3 = "Brasília";
Q6.Resposta4 = "Salvador";
Q6.Resposta5 = "Belo Horizonte";
Q6.Respostacorreta = 3;

// Pergunta 7
var Q7 = new Questao();
Q7.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q7.Pergunta = "Em que ano o homem pisou na Lua pela primeira vez?";
Q7.Resposta1 = "1965";
Q7.Resposta2 = "1969";
Q7.Resposta3 = "1972";
Q7.Resposta4 = "1958";
Q7.Resposta5 = "1975";
Q7.Respostacorreta = 2;

// Pergunta 8
var Q8 = new Questao();
Q8.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q8.Pergunta = "Qual é o oceano mais profundo do mundo?";
Q8.Resposta1 = "Oceano Atlântico";
Q8.Resposta2 = "Oceano Índico";
Q8.Resposta3 = "Oceano Pacífico";
Q8.Resposta4 = "Oceano Ártico";
Q8.Resposta5 = "Oceano Antártico";
Q8.Respostacorreta = 3;

// Pergunta 9
var Q9 = new Questao();
Q9.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q9.Pergunta = "Quem escreveu 'Dom Quixote'?";
Q9.Resposta1 = "Gabriel García Márquez";
Q9.Resposta2 = "Jorge Luis Borges";
Q9.Resposta3 = "Miguel de Cervantes";
Q9.Resposta4 = "Mario Vargas Llosa";
Q9.Resposta5 = "Pablo Neruda";
Q9.Respostacorreta = 3;

// Pergunta 10
var Q10 = new Questao();
Q10.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q10.Pergunta = "Qual o metal cujo símbolo químico é 'Au'?";
Q10.Resposta1 = "Prata";
Q10.Resposta2 = "Mercúrio";
Q10.Resposta3 = "Ouro";
Q10.Resposta4 = "Alumínio";
Q10.Resposta5 = "Cobre";
Q10.Respostacorreta = 3;

// Pergunta 11
var Q11 = new Questao();
Q11.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q11.Pergunta = "Quem foi o primeiro homem a pisar na Lua?";
Q11.Resposta1 = "Buzz Aldrin";
Q11.Resposta2 = "Neil Armstrong";
Q11.Resposta3 = "Yuri Gagarin";
Q11.Resposta4 = "Michael Collins";
Q11.Resposta5 = "John Glenn";
Q11.Respostacorreta = 2;

// Pergunta 12
var Q12 = new Questao();
Q12.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q12.Pergunta = "Em que continente fica o Egito?";
Q12.Resposta1 = "Europa";
Q12.Resposta2 = "Ásia";
Q12.Resposta3 = "América do Norte";
Q12.Resposta4 = "África";
Q12.Resposta5 = "América do Sul";
Q12.Respostacorreta = 4;

// Pergunta 13
var Q13 = new Questao();
Q13.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q13.Pergunta = "Qual é o órgão responsável por bombear o sangue no corpo humano?";
Q13.Resposta1 = "Pulmões";
Q13.Resposta2 = "Cérebro";
Q13.Resposta3 = "Rins";
Q13.Resposta4 = "Coração";
Q13.Resposta5 = "Fígado";
Q13.Respostacorreta = 4;

// Pergunta 14
var Q14 = new Questao();
Q14.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q14.Pergunta = "Qual é a fórmula química da água?";
Q14.Resposta1 = "H2O";
Q14.Resposta2 = "CO2";
Q14.Resposta3 = "O2";
Q14.Resposta4 = "NaCl";
Q14.Resposta5 = "CH4";
Q14.Respostacorreta = 1;

// Pergunta 15
var Q15 = new Questao();
Q15.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q15.Pergunta = "Qual é o país com o maior número de Copas do Mundo de Futebol?";
Q15.Resposta1 = "Itália";
Q15.Resposta2 = "Alemanha";
Q15.Resposta3 = "Brasil";
Q15.Resposta4 = "Argentina";
Q15.Resposta5 = "França";
Q15.Respostacorreta = 3;

// Pergunta 16
var Q16 = new Questao();
Q16.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q16.Pergunta = "Quem descobriu o Brasil?";
Q16.Resposta1 = "Pedro Álvares Cabral";
Q16.Resposta2 = "Cristóvão Colombo";
Q16.Resposta3 = "Américo Vespúcio";
Q16.Resposta4 = "Fernão de Magalhães";
Q16.Resposta5 = "Vasco da Gama";
Q16.Respostacorreta = 1;

// Pergunta 17
var Q17 = new Questao();
Q17.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q17.Pergunta = "Qual o símbolo químico do gás hélio?";
Q17.Resposta1 = "H";
Q17.Resposta2 = "He";
Q17.Resposta3 = "Ho";
Q17.Resposta4 = "Hi";
Q17.Resposta5 = "Hf";
Q17.Respostacorreta = 2;

// Pergunta 18
var Q18 = new Questao();
Q18.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q18.Pergunta = "Quantos ossos tem o corpo humano adulto?";
Q18.Resposta1 = "201";
Q18.Resposta2 = "204";
Q18.Resposta3 = "206";
Q18.Resposta4 = "208";
Q18.Resposta5 = "210";
Q18.Respostacorreta = 3;

// Pergunta 19
var Q19 = new Questao();
Q19.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q19.Pergunta = "Qual é o país de origem do samba?";
Q19.Resposta1 = "Argentina";
Q19.Resposta2 = "Brasil";
Q19.Resposta3 = "Cuba";
Q19.Resposta4 = "México";
Q19.Resposta5 = "Colômbia";
Q19.Respostacorreta = 2;

// Pergunta 20
var Q20 = new Questao();
Q20.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q20.Pergunta = "Quem é o autor de 'O Pequeno Príncipe'?";
Q20.Resposta1 = "Antoine de Saint-Exupéry";
Q20.Resposta2 = "J.K. Rowling";
Q20.Resposta3 = "Ernest Hemingway";
Q20.Resposta4 = "Fiódor Dostoiévski";
Q20.Resposta5 = "Charles Dickens";
Q20.Respostacorreta = 1;

// Pergunta 21
var Q21 = new Questao();
Q21.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q21.Pergunta = "Quem inventou o telefone?";
Q21.Resposta1 = "Thomas Edison";
Q21.Resposta2 = "Alexander Graham Bell";
Q21.Resposta3 = "Nikola Tesla";
Q21.Resposta4 = "Guglielmo Marconi";
Q21.Resposta5 = "Samuel Morse";
Q21.Respostacorreta = 2;

// Pergunta 22
var Q22 = new Questao();
Q22.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q22.Pergunta = "Qual é o menor osso do corpo humano?";
Q22.Resposta1 = "Fíbula";
Q22.Resposta2 = "Martelo";
Q22.Resposta3 = "Estribo";
Q22.Resposta4 = "Bigorna";
Q22.Resposta5 = "Falange";
Q22.Respostacorreta = 3;

// Pergunta 23
var Q23 = new Questao();
Q23.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q23.Pergunta = "Qual é o nome científico da planta que dá origem ao cacau?";
Q23.Resposta1 = "Theobroma cacao";
Q23.Resposta2 = "Coffea arabica";
Q23.Resposta3 = "Camellia sinensis";
Q23.Resposta4 = "Hibiscus rosa-sinensis";
Q23.Resposta5 = "Capsicum annuum";
Q23.Respostacorreta = 1;

// Pergunta 24
var Q24 = new Questao();
Q24.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q24.Pergunta = "Qual é o maior oceano do mundo?";
Q24.Resposta1 = "Oceano Atlântico";
Q24.Resposta2 = "Oceano Índico";
Q24.Resposta3 = "Oceano Pacífico";
Q24.Resposta4 = "Oceano Ártico";
Q24.Resposta5 = "Oceano Antártico";
Q24.Respostacorreta = 3;

// Pergunta 25
var Q25 = new Questao();
Q25.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q25.Pergunta = "Qual é a montanha mais alta do mundo?";
Q25.Resposta1 = "Monte Everest";
Q25.Resposta2 = "K2";
Q25.Resposta3 = "Kangchenjunga";
Q25.Resposta4 = "Makalu";
Q25.Resposta5 = "Lhotse";
Q25.Respostacorreta = 1;

// Pergunta 26
var Q26 = new Questao();
Q26.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q26.Pergunta = "Qual foi o primeiro presidente do Brasil?";
Q26.Resposta1 = "Getúlio Vargas";
Q26.Resposta2 = "Deodoro da Fonseca";
Q26.Resposta3 = "Juscelino Kubitschek";
Q26.Resposta4 = "Dom Pedro II";
Q26.Resposta5 = "Floriano Peixoto";
Q26.Respostacorreta = 2;

// Pergunta 27
var Q27 = new Questao();
Q27.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q27.Pergunta = "Qual é o idioma oficial do Japão?";
Q27.Resposta1 = "Chinês";
Q27.Resposta2 = "Coreano";
Q27.Resposta3 = "Japonês";
Q27.Resposta4 = "Tailandês";
Q27.Resposta5 = "Vietnamita";
Q27.Respostacorreta = 3;

// Pergunta 28
var Q28 = new Questao();
Q28.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q28.Pergunta = "Qual é a capital da Austrália?";
Q28.Resposta1 = "Sydney";
Q28.Resposta2 = "Melbourne";
Q28.Resposta3 = "Brisbane";
Q28.Resposta4 = "Canberra";
Q28.Resposta5 = "Perth";
Q28.Respostacorreta = 4;

// Pergunta 29
var Q29 = new Questao();
Q29.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q29.Pergunta = "Quantos anéis tem o símbolo das Olimpíadas?";
Q29.Resposta1 = "3";
Q29.Resposta2 = "4";
Q29.Resposta3 = "5";
Q29.Resposta4 = "6";
Q29.Resposta5 = "7";
Q29.Respostacorreta = 3;

// Pergunta 30
var Q30 = new Questao();
Q30.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q30.Pergunta = "Qual é o maior país do mundo em extensão territorial?";
Q30.Resposta1 = "Estados Unidos";
Q30.Resposta2 = "Canadá";
Q30.Resposta3 = "Brasil";
Q30.Resposta4 = "China";
Q30.Resposta5 = "Rússia";
Q30.Respostacorreta = 5;

// Pergunta 31
var Q31 = new Questao();
Q31.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q31.Pergunta = "Quem descobriu a gravidade ao observar a queda de uma maçã?";
Q31.Resposta1 = "Galileu Galilei";
Q31.Resposta2 = "Isaac Newton";
Q31.Resposta3 = "Albert Einstein";
Q31.Resposta4 = "Nikola Tesla";
Q31.Resposta5 = "Thomas Edison";
Q31.Respostacorreta = 2;

// Pergunta 32
var Q32 = new Questao();
Q32.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q32.Pergunta = "Em que país foram realizados os primeiros Jogos Olímpicos modernos?";
Q32.Resposta1 = "França";
Q32.Resposta2 = "Estados Unidos";
Q32.Resposta3 = "Reino Unido";
Q32.Resposta4 = "Grécia";
Q32.Resposta5 = "Alemanha";
Q32.Respostacorreta = 4;

// Pergunta 33
var Q33 = new Questao();
Q33.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q33.Pergunta = "Qual foi o primeiro animal a ser clonado com sucesso?";
Q33.Resposta1 = "Cachorro";
Q33.Resposta2 = "Vaca";
Q33.Resposta3 = "Rato";
Q33.Resposta4 = "Ovelha";
Q33.Resposta5 = "Coelho";
Q33.Respostacorreta = 4;

// Pergunta 34
var Q34 = new Questao();
Q34.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q34.Pergunta = "Qual é o principal ingrediente da cerveja?";
Q34.Resposta1 = "Cevada";
Q34.Resposta2 = "Trigo";
Q34.Resposta3 = "Milho";
Q34.Resposta4 = "Arroz";
Q34.Resposta5 = "Centeio";
Q34.Respostacorreta = 1;

// Pergunta 35
var Q35 = new Questao();
Q35.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q35.Pergunta = "Qual país é conhecido como a terra do sol nascente?";
Q35.Resposta1 = "China";
Q35.Resposta2 = "Coreia do Sul";
Q35.Resposta3 = "Tailândia";
Q35.Resposta4 = "Japão";
Q35.Resposta5 = "Filipinas";
Q35.Respostacorreta = 4;

// Pergunta 36
var Q36 = new Questao();
Q36.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q36.Pergunta = "Qual foi o nome do primeiro satélite artificial a orbitar a Terra?";
Q36.Resposta1 = "Apollo 11";
Q36.Resposta2 = "Vostok 1";
Q36.Resposta3 = "Sputnik 1";
Q36.Resposta4 = "Explorer 1";
Q36.Resposta5 = "Voyager 1";
Q36.Respostacorreta = 3;

// Pergunta 37
var Q37 = new Questao();
Q37.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q37.Pergunta = "Qual é o continente mais frio do mundo?";
Q37.Resposta1 = "Europa";
Q37.Resposta2 = "Ásia";
Q37.Resposta3 = "América do Norte";
Q37.Resposta4 = "Antártida";
Q37.Resposta5 = "África";
Q37.Respostacorreta = 4;

// Pergunta 38
var Q38 = new Questao();
Q38.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q38.Pergunta = "Qual país tem o formato aproximado de uma bota?";
Q38.Resposta1 = "Itália";
Q38.Resposta2 = "Grécia";
Q38.Resposta3 = "Espanha";
Q38.Resposta4 = "Turquia";
Q38.Resposta5 = "Portugal";
Q38.Respostacorreta = 1;

// Pergunta 39
var Q39 = new Questao();
Q39.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q39.Pergunta = "Qual é o maior deserto quente do mundo?";
Q39.Resposta1 = "Deserto do Saara";
Q39.Resposta2 = "Deserto de Gobi";
Q39.Resposta3 = "Deserto da Arábia";
Q39.Resposta4 = "Deserto de Atacama";
Q39.Resposta5 = "Deserto da Namíbia";
Q39.Respostacorreta = 1;

// Pergunta 40
var Q40 = new Questao();
Q40.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q40.Pergunta = "Qual o nome da famosa torre inclinada localizada na Itália?";
Q40.Resposta1 = "Torre Eiffel";
Q40.Resposta2 = "Torre de Pisa";
Q40.Resposta3 = "Torre de Londres";
Q40.Resposta4 = "Torre de Tóquio";
Q40.Resposta5 = "Torre de Seul";
Q40.Respostacorreta = 2;

// Pergunta 26
var Q26 = new Questao();
Q26.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q26.Pergunta = "Qual foi o primeiro presidente do Brasil?";
Q26.Resposta1 = "Getúlio Vargas";
Q26.Resposta2 = "Deodoro da Fonseca";
Q26.Resposta3 = "Juscelino Kubitschek";
Q26.Resposta4 = "Dom Pedro II";
Q26.Resposta5 = "Floriano Peixoto";
Q26.Respostacorreta = 2;

// Pergunta 27
var Q27 = new Questao();
Q27.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q27.Pergunta = "Qual é o idioma oficial do Japão?";
Q27.Resposta1 = "Chinês";
Q27.Resposta2 = "Coreano";
Q27.Resposta3 = "Japonês";
Q27.Resposta4 = "Tailandês";
Q27.Resposta5 = "Vietnamita";
Q27.Respostacorreta = 3;

// Pergunta 28
var Q28 = new Questao();
Q28.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q28.Pergunta = "Qual é a capital da Austrália?";
Q28.Resposta1 = "Sydney";
Q28.Resposta2 = "Melbourne";
Q28.Resposta3 = "Brisbane";
Q28.Resposta4 = "Canberra";
Q28.Resposta5 = "Perth";
Q28.Respostacorreta = 4;

// Pergunta 29
var Q29 = new Questao();
Q29.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q29.Pergunta = "Quantos anéis tem o símbolo das Olimpíadas?";
Q29.Resposta1 = "3";
Q29.Resposta2 = "4";
Q29.Resposta3 = "5";
Q29.Resposta4 = "6";
Q29.Resposta5 = "7";
Q29.Respostacorreta = 3;

// Pergunta 30
var Q30 = new Questao();
Q30.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q30.Pergunta = "Qual é o maior país do mundo em extensão territorial?";
Q30.Resposta1 = "Estados Unidos";
Q30.Resposta2 = "Canadá";
Q30.Resposta3 = "Brasil";
Q30.Resposta4 = "China";
Q30.Resposta5 = "Rússia";
Q30.Respostacorreta = 5;

// Pergunta 31
var Q31 = new Questao();
Q31.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q31.Pergunta = "Quem descobriu a gravidade ao observar a queda de uma maçã?";
Q31.Resposta1 = "Galileu Galilei";
Q31.Resposta2 = "Isaac Newton";
Q31.Resposta3 = "Albert Einstein";
Q31.Resposta4 = "Nikola Tesla";
Q31.Resposta5 = "Thomas Edison";
Q31.Respostacorreta = 2;

// Pergunta 32
var Q32 = new Questao();
Q32.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q32.Pergunta = "Em que país foram realizados os primeiros Jogos Olímpicos modernos?";
Q32.Resposta1 = "França";
Q32.Resposta2 = "Estados Unidos";
Q32.Resposta3 = "Reino Unido";
Q32.Resposta4 = "Grécia";
Q32.Resposta5 = "Alemanha";
Q32.Respostacorreta = 4;

// Pergunta 33
var Q33 = new Questao();
Q33.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q33.Pergunta = "Qual foi o primeiro animal a ser clonado com sucesso?";
Q33.Resposta1 = "Cachorro";
Q33.Resposta2 = "Vaca";
Q33.Resposta3 = "Rato";
Q33.Resposta4 = "Ovelha";
Q33.Resposta5 = "Coelho";
Q33.Respostacorreta = 4;

// Pergunta 34
var Q34 = new Questao();
Q34.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q34.Pergunta = "Qual é o principal ingrediente da cerveja?";
Q34.Resposta1 = "Cevada";
Q34.Resposta2 = "Trigo";
Q34.Resposta3 = "Milho";
Q34.Resposta4 = "Arroz";
Q34.Resposta5 = "Centeio";
Q34.Respostacorreta = 1;

// Pergunta 35
var Q35 = new Questao();
Q35.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q35.Pergunta = "Qual país é conhecido como a terra do sol nascente?";
Q35.Resposta1 = "China";
Q35.Resposta2 = "Coreia do Sul";
Q35.Resposta3 = "Tailândia";
Q35.Resposta4 = "Japão";
Q35.Resposta5 = "Filipinas";
Q35.Respostacorreta = 4;

// Pergunta 36
var Q36 = new Questao();
Q36.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q36.Pergunta = "Qual foi o nome do primeiro satélite artificial a orbitar a Terra?";
Q36.Resposta1 = "Apollo 11";
Q36.Resposta2 = "Vostok 1";
Q36.Resposta3 = "Sputnik 1";
Q36.Resposta4 = "Explorer 1";
Q36.Resposta5 = "Voyager 1";
Q36.Respostacorreta = 3;

// Pergunta 37
var Q37 = new Questao();
Q37.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q37.Pergunta = "Qual é o continente mais frio do mundo?";
Q37.Resposta1 = "Europa";
Q37.Resposta2 = "Ásia";
Q37.Resposta3 = "América do Norte";
Q37.Resposta4 = "Antártida";
Q37.Resposta5 = "África";
Q37.Respostacorreta = 4;

// Pergunta 38
var Q38 = new Questao();
Q38.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q38.Pergunta = "Qual país tem o formato aproximado de uma bota?";
Q38.Resposta1 = "Itália";
Q38.Resposta2 = "Grécia";
Q38.Resposta3 = "Espanha";
Q38.Resposta4 = "Turquia";
Q38.Resposta5 = "Portugal";
Q38.Respostacorreta = 1;

// Pergunta 39
var Q39 = new Questao();
Q39.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q39.Pergunta = "Qual é o maior deserto quente do mundo?";
Q39.Resposta1 = "Deserto do Saara";
Q39.Resposta2 = "Deserto de Gobi";
Q39.Resposta3 = "Deserto da Arábia";
Q39.Resposta4 = "Deserto de Atacama";
Q39.Resposta5 = "Deserto da Namíbia";
Q39.Respostacorreta = 1;

// Pergunta 40
var Q40 = new Questao();
Q40.ConfiguraEstruturaDesenho(labelPerg, buttonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
Q40.Pergunta = "Qual o nome da famosa torre inclinada localizada na Itália?";
Q40.Resposta1 = "Torre Eiffel";
Q40.Resposta2 = "Torre de Pisa";
Q40.Resposta3 = "Torre de Londres";
Q40.Resposta4 = "Torre de Tóquio";
Q40.Resposta5 = "Torre de Seul";
Q40.Respostacorreta = 2;




        }
            public async void VerificaCorreta (int rr)
            {
                if (QuestaoCorrente.VerificaResposta(rr))
                {
                    await Task.Delay(1000);
                    ProximaQuestao();
                }
            }

            void ProximaQuestao()
            {
                var numAleat=Random.Shared.Next(0,ListaQuestoes.Count);
                while (ListaQuestoesRespondidas.Contains(numAleat))
                numAleat=Random.Shared.Next(0,ListaQuestoes.Count);
                ListaQuestoesRespondidas.Add(numAleat);
                QuestaoCorrente=ListaQuestoes[numAleat];
                QuestaoCorrente.Desenhar();
            }

    }

}