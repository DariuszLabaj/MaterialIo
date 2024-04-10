# MaterialIo

## Usage

In your App.xaml file merge dictionaries with Resorces to get all styles etc.

```xaml
<ResourceDictionary Source="pack://application:,,,/MaterialIo;component/Resources.xaml"/>
```

In your xaml files add following line to get access to UserControlls

```xaml
        xmlns:material="clr-namespace:DariuszLabaj.MaterialIo.UserControll;assembly=MaterialIo"
```