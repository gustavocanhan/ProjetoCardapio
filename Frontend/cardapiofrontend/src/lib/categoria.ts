import { apiGet } from "./client";

export async function getCategorias() {
  return apiGet({ path: "/Categorias" });
}
