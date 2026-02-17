"use client";
import { useMemo, useState } from "react";
import Menu from "../menu/Menu";
import Search from "../search/Search";
import ContainerCard from "../card/ContainerCard";

type Categoria = {
  publicId: string;
  nome: string;
};

type Item = {
  publicId: string;
  nome: string;
  categoria: {
    nome: string;
  };
  descricao: string;
  preco: number;
};

type HomeContentProps = {
  categorias: Categoria[];
  itens: Item[];
};

export default function HomeContent({ categorias, itens }: HomeContentProps) {
  const [categoriaSelecionada, setCategoriaSelecionada] = useState("");
  const [searchTerm, setSearchTerm] = useState("");

  const norm = (v?: string) => (v ?? "").trim().toLowerCase();

  const termo = norm(searchTerm);
  const categoriaAtiva = norm(categoriaSelecionada);

  const itensFiltrados = itens.filter((item) => {
    const nome = norm(item.nome);
    const descricao = norm(item.descricao);
    const categoria = norm(item.categoria.nome);

    return (
      (!categoriaAtiva || categoria === categoriaAtiva) &&
      (!termo ||
        nome.includes(termo) ||
        descricao.includes(termo) ||
        categoria.includes(termo))
    );
  });

  return (
    <div className="pb-8">
      <Menu
        categorias={categorias}
        categoriaSelecionada={categoriaSelecionada}
        onCategoriaChange={setCategoriaSelecionada}
      />
      <Search searchTerm={searchTerm} onSearchTermChange={setSearchTerm} />
      <ContainerCard itens={itensFiltrados} />
    </div>
  );
}
