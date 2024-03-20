export interface MovieItems{
    id: number,
    title: string,
    timeOfMovie: string,
    withSubtitles: true,
    rating: number,
    actorId: number,
    actor: {
        id: number,
        name:string,
        aboutInfo:string
    }
}