﻿using System.ComponentModel;
public class ClassWithExistingOnChanged : INotifyPropertyChanged
{
    public bool OnProperty1ChangedCalled;
    string property1;

    public string Property1
    {
        get { return property1; }
        set
        {
            property1 = value;
            OnPropertyChanged("Property1");
            OnProperty1Changed();
        }
    }

    public void OnProperty1Changed()
    {
        OnProperty1ChangedCalled = true;
    }

    public event PropertyChangedEventHandler PropertyChanged;
    public virtual void OnPropertyChanged(string propertyName)
    {
        var handler = PropertyChanged;
        if (handler != null)
        {
            handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
