export interface image {
    id: number;
    name: string;
    imageURL: string;
    isShared: boolean;
    userId: number | undefined;
}