export default function Banner() {
  return (
    <div className="w-full h-50 bg-[url('/banner.png')] bg-no-repeat bg-center bg-cover flex flex-col items-center justify-center gap-4 px-4">
      <h1 className="text-white text-5xl font-semibold font-serif">Cardápio</h1>
      <h2 className="bg-background-yellow px-4 py-2 rounded-full text-background-red font-semibold shadow text-center">
        Confira os nossos deliciosos pratos e bebidas!
      </h2>
    </div>
  );
}
