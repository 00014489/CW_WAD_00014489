
import { RouterOutlet } from '@angular/router';
import { MatButton, MatButtonModule } from '@angular/material/button';
import { MovieItems } from './MovieItems';
import { HomeComponent } from './components/home/home.component';
import {Component} from '@angular/core';
import {MatIconModule} from '@angular/material/icon';
import {MatTableModule} from '@angular/material/table';
import {MatToolbarModule} from '@angular/material/toolbar';
export interface PeriodicElement {
  ID: number;
  Title: string;
  TimeOfMovie: string;
  withSubtitles: string;
  Rating: number;
  ActorName: string;
}
const ELEMENT_DATA: PeriodicElement[] = [
  {ID: 1, Title: 'Opengemmer', TimeOfMovie: "1.00.79", withSubtitles: 'Yes', Rating: 7.8, ActorName: 'OpengemmerName'},
  {ID: 2, Title: 'Flash', TimeOfMovie: "4.00.26", withSubtitles: 'No', Rating: 7.8, ActorName: 'FlashName',},
  {ID: 3, Title: 'Avvengers',TimeOfMovie: "6.94.01", withSubtitles: 'Yes', Rating: 7.8, ActorName: 'AvengerName'}
];

@Component({
  selector: 'app-root',
  standalone: true,
  imports:[MatToolbarModule, MatButtonModule, MatIconModule, MatTableModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})


export class AppComponent {
  title = 'movie-app';
   item:MovieItems[]=[]
   displayedColumns: string[] = ['ID', 'Title', 'TimeOfMovie', 'withSubtitles', 'Rating', 'ActorName'];
   dataSource = ELEMENT_DATA;
   create(){
    console.log("working")
   }
}
