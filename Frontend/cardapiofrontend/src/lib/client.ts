const API_URL = process.env.NEXT_PUBLIC_API_URL;

if (!API_URL) {
  throw new Error("API_URL is not defined in environment variables");
}

type ApiGet = {
  path: string;
};

export async function apiGet({ path }: ApiGet) {
  const res = await fetch(`${API_URL}${path}`, {
    method: "GET",
    cache: "no-cache",
    headers: {
      "Content-Type": "application/json",
    },
  });

  if (!res.ok) {
    throw new Error(`API request failed with status ${res.status}`);
  }

  return res.json();
}
