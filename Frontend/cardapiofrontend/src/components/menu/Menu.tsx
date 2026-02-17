import MenuItem from "./MenuItem";

type Categoria = {
  publicId: string;
  nome: string;
};

type MenuProps = {
  categorias: Categoria[];
  categoriaSelecionada: string;
  onCategoriaChange: (categoria: string) => void;
};

export default function Menu({
  categorias,
  categoriaSelecionada: categoriaSelecionada = "",
  onCategoriaChange,
}: MenuProps) {
  return (
    <div className="flex items-center gap-4 pb-4 overflow-x-auto md:justify-center md:flex-wrap py-4">
      {/* MenuItem Todos */}
      <MenuItem
        item={{ nome: "Todos" }}
        ativo={!categoriaSelecionada}
        onClick={() => onCategoriaChange("")}
      />

      {/* Renderiza um MenuItem para cada categoria */}
      {categorias.map((item) => (
        <MenuItem
          key={item.publicId}
          item={item}
          // Destaca visualmente o item selecionado
          ativo={categoriaSelecionada === item.nome}
          // Atualiza a categoria selecionada ao clicar
          onClick={() => onCategoriaChange(item.nome)}
        />
      ))}
    </div>
  );
}
