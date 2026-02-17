
-- SEED CATEGORIAS
INSERT INTO Categorias (PublicId, Nome, Descricao) VALUES
(UUID(),'Pizza','Pizzas tradicionais'),
(UUID(),'Esfiha','Esfihas'),
(UUID(),'Refrigerante','Bebidas gaseificadas'),
(UUID(),'Lanches','Sanduíches'),
(UUID(),'Porções','Porções'),
(UUID(),'Massas','Massas'),
(UUID(),'Sobremesas','Sobremesas'),
(UUID(),'Bebidas Quentes','Bebidas quentes'),
(UUID(),'Sucos','Sucos naturais'),
(UUID(),'Pratos Executivos','Pratos completos'),
(UUID(),'Saladas','Saladas');

-- =========================
-- ITENS - PIZZA (10)
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'Pizza Calabresa','Calabresa e cebola',45.90,PublicId FROM Categorias WHERE Nome='Pizza';
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'Pizza Mussarela','Mussarela e orégano',42.90,PublicId FROM Categorias WHERE Nome='Pizza';
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'Pizza Portuguesa','Presunto, ovo e cebola',47.90,PublicId FROM Categorias WHERE Nome='Pizza';
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'Pizza Frango com Catupiry','Frango e catupiry',49.90,PublicId FROM Categorias WHERE Nome='Pizza';
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'Pizza Quatro Queijos','Mix de queijos',52.90,PublicId FROM Categorias WHERE Nome='Pizza';
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'Pizza Bacon','Bacon crocante',48.90,PublicId FROM Categorias WHERE Nome='Pizza';
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'Pizza Marguerita','Tomate e manjericão',46.90,PublicId FROM Categorias WHERE Nome='Pizza';
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'Pizza Pepperoni','Pepperoni fatiado',53.90,PublicId FROM Categorias WHERE Nome='Pizza';

-- ESFIHA (8)
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'Esfiha Carne','Carne temperada',6.50,PublicId FROM Categorias WHERE Nome='Esfiha';
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'Esfiha Queijo','Mussarela',6.50,PublicId FROM Categorias WHERE Nome='Esfiha';
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'Esfiha Frango','Frango desfiado',6.50,PublicId FROM Categorias WHERE Nome='Esfiha';
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'Esfiha Calabresa','Calabresa',6.50,PublicId FROM Categorias WHERE Nome='Esfiha';
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'Esfiha Escarola','Escarola refogada',6.50,PublicId FROM Categorias WHERE Nome='Esfiha';
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'Esfiha Ricota','Ricota temperada',6.50,PublicId FROM Categorias WHERE Nome='Esfiha';
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'Esfiha Chocolate','Chocolate',7.00,PublicId FROM Categorias WHERE Nome='Esfiha';
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'Esfiha Banana','Banana com canela',7.00,PublicId FROM Categorias WHERE Nome='Esfiha';

-- LANCHES (8)
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'X-Burguer','Hambúrguer e queijo',18.90,PublicId FROM Categorias WHERE Nome='Lanches';
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'X-Salada','Hambúrguer e salada',21.90,PublicId FROM Categorias WHERE Nome='Lanches';
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'X-Bacon','Hambúrguer e bacon',24.90,PublicId FROM Categorias WHERE Nome='Lanches';
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'X-Frango','Frango grelhado',23.90,PublicId FROM Categorias WHERE Nome='Lanches';
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'X-Egg','Hambúrguer e ovo',22.90,PublicId FROM Categorias WHERE Nome='Lanches';
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'X-Calabresa','Calabresa acebolada',21.90,PublicId FROM Categorias WHERE Nome='Lanches';
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'X-Tudo','Completo',29.90,PublicId FROM Categorias WHERE Nome='Lanches';
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'Misto Quente','Presunto e queijo',14.90,PublicId FROM Categorias WHERE Nome='Lanches';


-- PORÇÕES (3)
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'Batata Frita','Porção média',22.00,PublicId FROM Categorias WHERE Nome='Porções';
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'Polenta Frita','Porção crocante',20.00,PublicId FROM Categorias WHERE Nome='Porções';
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'Anéis de Cebola','Empanados',24.00,PublicId FROM Categorias WHERE Nome='Porções';

-- MASSAS (3)
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'Lasanha Bolonhesa','Carne e queijo',34.90,PublicId FROM Categorias WHERE Nome='Massas';
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'Spaghetti Carbonara','Molho cremoso',36.90,PublicId FROM Categorias WHERE Nome='Massas';
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'Penne ao Molho Branco','Molho branco',32.90,PublicId FROM Categorias WHERE Nome='Massas';

-- SOBREMESAS (3)
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'Pudim','Leite condensado',12.00,PublicId FROM Categorias WHERE Nome='Sobremesas';
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'Brownie','Chocolate',14.00,PublicId FROM Categorias WHERE Nome='Sobremesas';
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'Sorvete','Duas bolas',10.00,PublicId FROM Categorias WHERE Nome='Sobremesas';

-- BEBIDAS QUENTES (3)
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'Café Expresso','Café curto',5.00,PublicId FROM Categorias WHERE Nome='Bebidas Quentes';
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'Cappuccino','Café com leite',8.50,PublicId FROM Categorias WHERE Nome='Bebidas Quentes';
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'Chocolate Quente','Leite e chocolate',9.00,PublicId FROM Categorias WHERE Nome='Bebidas Quentes';

-- SUCOS (3)
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'Suco de Laranja','Natural',9.00,PublicId FROM Categorias WHERE Nome='Sucos';
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'Suco de Morango','Natural',10.00,PublicId FROM Categorias WHERE Nome='Sucos';
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'Suco de Abacaxi','Natural',9.50,PublicId FROM Categorias WHERE Nome='Sucos';

-- PRATOS EXECUTIVOS (3)
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'Prato Feito','Arroz, feijão e bife',24.90,PublicId FROM Categorias WHERE Nome='Pratos Executivos';
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'Strogonoff de Frango','Acompanha arroz',29.90,PublicId FROM Categorias WHERE Nome='Pratos Executivos';
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'Bife Acebolado','Arroz e feijão',27.90,PublicId FROM Categorias WHERE Nome='Pratos Executivos';

-- SALADAS (3)
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'Salada Caesar','Frango e parmesão',22.00,PublicId FROM Categorias WHERE Nome='Saladas';
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'Salada Verde','Folhas frescas',18.00,PublicId FROM Categorias WHERE Nome='Saladas';
INSERT INTO Itens (PublicId,Nome,Descricao,Preco,CategoriaPublicId) SELECT UUID(),'Salada Caprese','Tomate e mussarela',21.00,PublicId FROM Categorias WHERE Nome='Saladas';
