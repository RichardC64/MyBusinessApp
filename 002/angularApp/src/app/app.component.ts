import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { WeatherForecastService } from './services/weather-forecast.service';


@Component({
  selector: 'app-root',
  imports: [RouterOutlet],
  templateUrl: './app.component.html'
})
export class AppComponent {

  constructor(private weartherForecastService: WeatherForecastService){}

  clickNumber = 0;
  onClick() {
    this.weartherForecastService.getWeatherForecast().subscribe(result => {
      this.clickNumber++;
      console.log(result);
    });
  }
}
