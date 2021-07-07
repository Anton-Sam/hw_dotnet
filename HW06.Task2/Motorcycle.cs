using System;

namespace HW06.Task2
{
    enum EngineType
    {
        Petrol,
        Electro,
        Hybrid,
    }
    class Motorcycle
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Model { get; private set; }
        public string Manufacturer { get; private set; }
        public DateTime CreationDate { get; } = DateTime.Now;
        public uint Odometre { get; private set; }
        public Engine MotoEngine { get; private set; }

        public Motorcycle(string model, string manufacturer, uint odometre, ushort volume, ushort power, string engineType) =>
            (Model, Manufacturer, Odometre, MotoEngine) = (model, manufacturer, odometre, new Engine(volume, power, engineType));

        public void Reset() => Console.WriteLine("Сброс в заводское состояние");

        public override string ToString() =>
            $"Мотоцикл (Производитель): \"{Manufacturer}\",\nМодель: \"{Model}\",\nVin Number (Идентификатор): \"{Id}\",\nГод: {CreationDate.Year}\n{MotoEngine.ToString()}";

        public class Engine
        {
            private ushort volume;
            private ushort power;
            private EngineType engineType;

            public ushort Volume
            {
                get => volume;
                set
                {
                    if (value < 125 || value > 3200)
                        throw new ArgumentException("Volume can be more then 125 and less then 3200");
                    volume = value;
                }
            }
            public ushort Power
            {
                get => power;
                set
                {
                    if (value < 50 || value > 300)
                        throw new ArgumentException("Power can be more then 50 and less then 300");
                    power = value;
                }
            }
            public EngineType EngineType
            {
                get => engineType;
                set => engineType = value;
            }

            public Engine(ushort volume, ushort power, string engineTypeString)
            {
                Volume = volume;
                Power = power;
                SetEngineTypeFromString(engineTypeString);
            }

            private void SetEngineTypeFromString(string engineTypeString)
            {
                if (!Enum.TryParse(engineTypeString, true, out engineType))
                    throw new ArgumentException("Engine type can be only: Patrol,Electro or Hybrid");
            }

            public override string ToString() =>
                $"Двигатель (Объем): {Volume},\nМощность: {Power},\nТип двигателя: {EngineType}";
        }

    }
}
