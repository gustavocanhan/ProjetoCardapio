type MenuItemProps = {
  item: {
    nome: string;
  };
  ativo: boolean;
  onClick: () => void;
};

export default function MenuItem({ item, ativo, onClick }: MenuItemProps) {
  return (
    <button
      type="button"
      onClick={onClick}
      className={`text-sm px-6 py-1 whitespace-nowrap rounded-full cursor-pointer shadow transition-all duration-200 ease-in-out ${ativo ? "bg-background-red text-white" : "bg-gray-300 hover:bg-background-red hover:text-white"}`}
    >
      {item.nome}
    </button>
  );
}
