import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class WeatherForecastService {

  constructor(private httpClient: HttpClient) { }

  getWeatherForecast() {
    return this.httpClient.get('https://localhost:7002/weatherforecast/');
  }
}
