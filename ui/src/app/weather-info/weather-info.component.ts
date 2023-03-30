import { Component } from '@angular/core';
import { WeatherForecastDataService } from '../services/weather-forecast-data.service';

@Component({
  selector: 'app-weather-info',
  templateUrl: './weather-info.component.html',
  styleUrls: ['./weather-info.component.css']
})
export class WeatherInfoComponent {
  title = 'WeatherForecast';

  constructor(private wf: WeatherForecastDataService) {
    this.fetchData();
  }
  weatherInfo: any;
  status: boolean = false;
  ngOnInit() {
    if (this.weatherInfo = null) {
      this.status = true;
    }
  }


  fetchData() {
    this.wf.getWeatherInfo().subscribe((data: any) => {
      this.weatherInfo = data;
    })
  }
}
