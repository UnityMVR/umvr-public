// <auto-generated>
//	 This code was generated by a tool.
//
//	 Changes to this file may cause incorrect behavior and will be lost if
//	 the code is regenerated.
// </auto-generated>

using pindwin.umvr.Model;
using System.Collections.Generic;
using UniRx;

// ReSharper disable once CheckNamespace
namespace pindwin.umvr.example
{
	public partial class FooModel : Model<FooModel>, IFoo
	{
		private ModelSingleProperty<pindwin.umvr.example.IFoo> _otherFoo;
		public pindwin.umvr.example.IFoo OtherFoo
		{
			get => _otherFoo.Value;
			set
			{
				if(_otherFoo.Value != null) { _otherFoo.Value.Disposing -= CascadeDispose; }
				_otherFoo.Value = value;
				if(_otherFoo.Value != null) { _otherFoo.Value.Disposing += CascadeDispose; }
			}
		}

		private CollectionProperty<System.Int32> _collection;
		public IList<System.Int32> Collection
		{
			get => _collection.Collection;
			set => _collection = new CollectionProperty<System.Int32>(nameof(Collection), _collection.Collection, value);
		}

		private ModelCollectionProperty<pindwin.umvr.example.IFoo> _fooCollection;
		public IList<pindwin.umvr.example.IFoo> FooCollection
		{
			get => _fooCollection.Collection;
			set => _fooCollection = new ModelCollectionProperty<pindwin.umvr.example.IFoo>(nameof(FooCollection), _fooCollection.Collection, value);
		}


		public FooModel(pindwin.umvr.Model.Id id, System.String text2, pindwin.umvr.example.IFoo otherFoo) : base(id)
		{
			_text = new SingleProperty<System.String>(nameof(Text));
			Text = default;

			Text2 = text2;

			_otherFoo = new ModelSingleProperty<pindwin.umvr.example.IFoo>(nameof(OtherFoo));
			OtherFoo = otherFoo;
			Disposing += _ => OtherFoo?.Dispose();

			_collection = new CollectionProperty<System.Int32>(nameof(Collection));
			Collection = default;

			_fooCollection = new ModelCollectionProperty<pindwin.umvr.example.IFoo>(nameof(FooCollection));
			FooCollection = default;

			RegisterDataStreams(this);
		}
	}
}