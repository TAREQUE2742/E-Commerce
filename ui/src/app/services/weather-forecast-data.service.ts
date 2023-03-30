import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class WeatherForecastDataService {

  constructor(private http: HttpClient) { }

  url: string = "https://localhost:5001/WeatherForecast";
  
  getWeatherInfo() {
    return this.http.get(this.url);
  }
}
