import Image from "next/image";
import logo from "../../../public/logo.png";
import { MapPin, Phone } from "lucide-react";

export default function Header() {
  return (
    <header className="flex bg-background-red text-white items-center justify-between px-2 py-4 md:px-8">
      <div className="flex items-center gap-2">
        <Phone className="md:size-4 size-3" />
        <p className="md:text-sm text-xs">(11) 99999-9999</p>
      </div>
      <Image src={logo} alt="Logo" className="w-8" />
      <div className="flex items-center gap-2 w-35 md:w-auto">
        <MapPin className="md:size-4 size-6" />
        <p className="md:text-sm text-xs">Rua Exemplo, 123 - Bairro, Cidade</p>
      </div>
    </header>
  );
}
