# Projeto MercadoMVC

## Instalação do projeto
<ul>
 <li> Vá na pasta Data, em Context.cs na conectionString coloque a String de conexão do seu banco de dados SQL express.</li>
 <li> Execute pelo console nugget o comando "update-database", caso ter o migrations - se não tiver, crie o migrate com "add-migration NomeDoMigration" e posteriormente execute update-database.</li>
 <li> Utilizei .NET Core 5 e Entity Framework (com suas ramificações) 5.0.3 no VS 2019.</li>
</ul>

## Descrição

 <li> 
  Há duas Models
 </li>
 
 ### Categoria
 <ul>
 <li> int: Id; </li>
  <li> String: Descrição; </li>
  </ul>
  
  ### Produto
  <ul>
   <li> int: id; </li>
    <li> string: Descricao; </li>
     <li> int: Quantidade; </li>
      <li> int: CategoriaID; </li>
       <li> Há uma relação com a tabela Categoria na qual o Id e descrição vem da tabela categoria; </li>
  </ul>
