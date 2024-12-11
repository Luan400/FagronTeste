export class Jogo {
    id?: number; 
    date!: string;
    points!: number;

    constructor(date: string, points: number, id?: number) {
        this.date = date;
        this.points = points;
        if (id) this.id = id;
      }
}