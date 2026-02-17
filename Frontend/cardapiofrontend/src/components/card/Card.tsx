type itemProps = {
  nome: string;
  categoria: string;
  descricao: string;
  preco: string;
};

export default function Card({ nome, categoria, descricao, preco }: itemProps) {
  return (
    <div className="bg-background-white shadow border border-gray-100 rounded-lg p-4">
      <h1 className="font-semibold text-lg pb-1">{nome}</h1>
      <small className="bg-background-red text-white text-xs rounded-full px-2 py-0.5 flex items-center justify-center w-fit">
        {categoria}
      </small>
      <p className="text-sm py-4 h-20">{descricao}</p>
      <span className="flex justify-end font-semibold">R$ {preco}</span>
    </div>
  );
}
