export class Resultados{
    id!: number; 
  firstGameDate!: Date; 
  lastGameDate!: Date; 
  gamesPlayed!: number; 
  totalPoints!: number; 
  averagePoints!: number;
  highestPoints!: number; 
  lowestPoints!: number; 
  vezesQuebrouRecorde!: number; 

  constructor(
    id: number = 0,
    firstGameDate: Date = new Date(),
    lastGameDate: Date = new Date(),
    gamesPlayed: number = 0,
    totalPoints: number = 0,
    averagePoints: number = 0,
    highestPoints: number = 0,
    lowestPoints: number = 0,
    vezesQuebrouRecorde: number = 0
  ) {
    this.id = id;
    this.firstGameDate = firstGameDate;
    this.lastGameDate = lastGameDate;
    this.gamesPlayed = gamesPlayed;
    this.totalPoints = totalPoints;
    this.averagePoints = averagePoints;
    this.highestPoints = highestPoints;
    this.lowestPoints = lowestPoints;
    this.vezesQuebrouRecorde = vezesQuebrouRecorde;
  }
}