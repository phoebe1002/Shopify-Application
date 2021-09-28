import { image } from "./image";

export interface user {
    id: number;
    email: string | undefined;
    images: null | image[];
}