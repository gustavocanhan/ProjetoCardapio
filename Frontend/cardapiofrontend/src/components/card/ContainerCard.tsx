"use client";

import { useEffect, useMemo, useState } from "react";
import Card from "./Card";
import { ChevronLeft, ChevronRight } from "lucide-react";

type itemProps = {
  publicId: string;
  nome: string;
  categoria: {
    nome: string;
  };
  descricao: string;
  preco: number;
};

type ContainerCardProps = {
  itens: itemProps[];
};

export default function ContainerCard({ itens }: ContainerCardProps) {
  // Quantidade fixa de cards por pagina
  const cardsPorPagina = 9;

  // Estado da pagina atual (comeca em 1)
  const [paginaAtual, setPaginaAtual] = useState(1);

  // Total de paginas com minimo 1 para manter a navegacao estavel, mesmo sem itens
  const totalPaginas = Math.max(1, Math.ceil(itens.length / cardsPorPagina));

  // Recorte da lista que corresponde a pagina atual
  // useMemo evita recalculo em renderizacao sem mudanca relevante
  const itensDaPagina = useMemo(() => {
    // Indice inicial e final do slice para pagina atual
    const inicio = (paginaAtual - 1) * cardsPorPagina;
    const fim = inicio + cardsPorPagina;
    return itens.slice(inicio, fim);
  }, [paginaAtual, itens, cardsPorPagina]);

  // Ajuste de seguranca:
  // se os filtros reduzirem a quantidade de itens e a pagina atual ficar invalida,
  // move automaticamente para a ultima pagina disponivel
  useEffect(() => {
    if (paginaAtual > totalPaginas) {
      setPaginaAtual(totalPaginas);
    }
  }, [paginaAtual, totalPaginas]);

  function irParaPagina(pagina: number) {
    if (pagina < 1 || pagina > totalPaginas) return;
    setPaginaAtual(pagina);
  }

  return (
    <div className="flex flex-col gap-2">
      <div className="w-full grid md:grid-cols-3 grid-cols-1 gap-4 p-4">
        {itensDaPagina.map((item) => (
          <Card
            key={item.publicId}
            nome={item.nome}
            categoria={item.categoria.nome}
            descricao={item.descricao}
            preco={item.preco.toFixed(2).toString().replace(".", ",")}
          />
        ))}
      </div>

      <div className="flex items-center justify-center gap-2 mt-4">
        <button
          className="px-3 py-1 rounded border disabled:opacity-40 cursor-pointer hover:bg-gray-200"
          onClick={() => irParaPagina(paginaAtual - 1)}
          disabled={paginaAtual === 1}
        >
          <ChevronLeft className="w-6 h-6" />
        </button>

        {Array.from({ length: totalPaginas }, (_, i) => i + 1).map((pagina) => (
          <button
            key={pagina}
            onClick={() => irParaPagina(pagina)}
            className={`px-3 py-1 rounded border cursor-pointer hover:bg-gray-200 ${paginaAtual === pagina ? "font-bold bg-gray-200" : ""}`}
          >
            {pagina}
          </button>
        ))}

        <button
          className="px-3 py-1 rounded border disabled:opacity-40 cursor-pointer hover:bg-gray-200"
          onClick={() => irParaPagina(paginaAtual + 1)}
          disabled={paginaAtual === totalPaginas}
        >
          <ChevronRight className="w-6 h-6" />
        </button>
      </div>
    </div>
  );
}
