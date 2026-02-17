import { apiGet } from "./client";

export async function getItens() {
  return apiGet({ path: "/Item" });
}
