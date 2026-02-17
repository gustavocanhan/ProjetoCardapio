import Banner from "@/components/banner/Banner";
import HomeContent from "@/components/content/HomeContent";
import { getCategorias } from "@/lib/categoria";
import { getItens } from "@/lib/item";

export default async function Home() {
  const [categorias, itens] = await Promise.all([getCategorias(), getItens()]);
  return (
    <div>
      <Banner />
      <div className="max-w-5xl mx-auto p-4">
        <HomeContent categorias={categorias} itens={itens} />
      </div>
    </div>
  );
}
