import { Clock2, MapPin, Phone } from "lucide-react";

export default function Footer() {
  return (
    <footer className="bg-background-red text-white flex md:justify-between px-8 py-4 flex-col md:flex-row gap-6 mt-auto">
      <div className="flex gap-2 items-start">
        <Phone size={16} />
        <div className="text-xs">
          <p className="font-semibold pb-0.5">Ligue para:</p>
          <p>(11) 99999-9999</p>
          <p>E-mail: contato@restaurante.com</p>
        </div>
      </div>

      <div className="flex gap-2 items-start">
        <MapPin size={16} />
        <div className="text-xs">
          <p className="font-semibold pb-0.5">Endereço:</p>
          <p>Rua Exemplo, 123</p>
          <p>Bairro, Cidade - Estado</p>
        </div>
      </div>

      <div className="flex gap-2 items-start">
        <Clock2 size={16} />
        <div className="text-xs">
          <p className="font-semibold pb-0.5">Horário de Funcionamento:</p>
          <p>Terça a Domingo</p>
          <p>18:00 às 23:00</p>
        </div>
      </div>
    </footer>
  );
}
