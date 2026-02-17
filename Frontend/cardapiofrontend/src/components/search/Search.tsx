import { SearchIcon, X } from "lucide-react";

type SearchProps = {
  searchTerm: string;
  onSearchTermChange: (term: string) => void;
};

export default function Search({
  searchTerm = "",
  onSearchTermChange,
}: SearchProps) {
  return (
    <div className="relative md:max-w-md mx-auto py-4">
      <SearchIcon
        className="absolute top-1/2 -translate-y-1/2 left-2 text-gray-400"
        size={18}
      />
      <input
        type="text"
        value={searchTerm}
        onChange={(e) => onSearchTermChange(e.target.value)}
        className="border border-gray-300 rounded-full px-8 py-2 shadow outline-none w-full"
        placeholder="Busque no cardápio..."
      />
      {searchTerm && (
        <X
          className="absolute top-1/2 -translate-y-1/2 right-4 text-gray-400 cursor-pointer"
          size={18}
          onClick={() => onSearchTermChange("")}
        />
      )}
    </div>
  );
}
