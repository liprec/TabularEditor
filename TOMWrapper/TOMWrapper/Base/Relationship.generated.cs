
// Code generated by a template
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using TabularEditor.PropertyGridUI;
using TabularEditor.UndoFramework;
using System.Drawing.Design;
using TOM = Microsoft.AnalysisServices.Tabular;
namespace TabularEditor.TOMWrapper
{
  
    /// <summary>
	/// Base class declaration for Relationship
	/// </summary>
	[TypeConverter(typeof(DynamicPropertyConverter))]
	public abstract partial class Relationship: TabularNamedObject
			, IAnnotationObject
			, IDeletableObject
	{
	    protected internal new TOM.Relationship MetadataObject { get { return base.MetadataObject as TOM.Relationship; } internal set { base.MetadataObject = value; } }

        /// <summary>
        /// Gets or sets the ToTable of the Relationship.
        /// </summary>
		[DisplayName("To Table")]
		[Category("Other"),IntelliSense("The To Table of this Relationship.")]
		public Table ToTable {
			get {
				if (MetadataObject.ToTable == null) return null;
			    return Handler.WrapperLookup[MetadataObject.ToTable] as Table;
            }
			
		}
		private bool ShouldSerializeToTable() { return false; }
        /// <summary>
        /// Gets or sets the FromTable of the Relationship.
        /// </summary>
		[DisplayName("From Table")]
		[Category("Other"),IntelliSense("The From Table of this Relationship.")]
		public Table FromTable {
			get {
				if (MetadataObject.FromTable == null) return null;
			    return Handler.WrapperLookup[MetadataObject.FromTable] as Table;
            }
			
		}
		private bool ShouldSerializeFromTable() { return false; }
		public string GetAnnotation(string name) {
		    return MetadataObject.Annotations.Find(name)?.Value;
		}
		public void SetAnnotation(string name, string value, bool undoable = true) {
			if(MetadataObject.Annotations.Contains(name)) {
				MetadataObject.Annotations[name].Value = value;
			} else {
				MetadataObject.Annotations.Add(new TOM.Annotation{ Name = name, Value = value });
			}
			if (undoable) Handler.UndoManager.Add(new UndoAnnotationAction(this, name, value));
		}
		        /// <summary>
        /// Gets or sets the IsActive of the Relationship.
        /// </summary>
		[DisplayName("Active")]
		[Category("Relationship"),IntelliSense("The Active of this Relationship.")]
		public bool IsActive {
			get {
			    return MetadataObject.IsActive;
			}
			set {
				var oldValue = IsActive;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("IsActive", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.IsActive = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "IsActive", oldValue, value));
				OnPropertyChanged("IsActive", oldValue, value);
			}
		}
		private bool ShouldSerializeIsActive() { return false; }
        /// <summary>
        /// Gets or sets the Type of the Relationship.
        /// </summary>
		[DisplayName("Type")]
		[Category("Other"),IntelliSense("The Type of this Relationship.")]
		public TOM.RelationshipType Type {
			get {
			    return MetadataObject.Type;
			}
			
		}
		private bool ShouldSerializeType() { return false; }
        /// <summary>
        /// Gets or sets the CrossFilteringBehavior of the Relationship.
        /// </summary>
		[DisplayName("Cross Filtering Behavior")]
		[Category("Relationship"),IntelliSense("The Cross Filtering Behavior of this Relationship.")]
		public TOM.CrossFilteringBehavior CrossFilteringBehavior {
			get {
			    return MetadataObject.CrossFilteringBehavior;
			}
			set {
				var oldValue = CrossFilteringBehavior;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("CrossFilteringBehavior", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.CrossFilteringBehavior = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "CrossFilteringBehavior", oldValue, value));
				OnPropertyChanged("CrossFilteringBehavior", oldValue, value);
			}
		}
		private bool ShouldSerializeCrossFilteringBehavior() { return false; }
        /// <summary>
        /// Gets or sets the JoinOnDateBehavior of the Relationship.
        /// </summary>
		[DisplayName("Join On Date Behavior")]
		[Category("Other"),IntelliSense("The Join On Date Behavior of this Relationship.")]
		public TOM.DateTimeRelationshipBehavior JoinOnDateBehavior {
			get {
			    return MetadataObject.JoinOnDateBehavior;
			}
			set {
				var oldValue = JoinOnDateBehavior;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("JoinOnDateBehavior", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.JoinOnDateBehavior = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "JoinOnDateBehavior", oldValue, value));
				OnPropertyChanged("JoinOnDateBehavior", oldValue, value);
			}
		}
		private bool ShouldSerializeJoinOnDateBehavior() { return false; }
        /// <summary>
        /// Gets or sets the RelyOnReferentialIntegrity of the Relationship.
        /// </summary>
		[DisplayName("Rely On Referential Integrity")]
		[Category("Other"),IntelliSense("The Rely On Referential Integrity of this Relationship.")]
		public bool RelyOnReferentialIntegrity {
			get {
			    return MetadataObject.RelyOnReferentialIntegrity;
			}
			set {
				var oldValue = RelyOnReferentialIntegrity;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("RelyOnReferentialIntegrity", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.RelyOnReferentialIntegrity = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "RelyOnReferentialIntegrity", oldValue, value));
				OnPropertyChanged("RelyOnReferentialIntegrity", oldValue, value);
			}
		}
		private bool ShouldSerializeRelyOnReferentialIntegrity() { return false; }
        /// <summary>
        /// Gets or sets the State of the Relationship.
        /// </summary>
		[DisplayName("State")]
		[Category("Metadata"),IntelliSense("The State of this Relationship.")]
		public TOM.ObjectState State {
			get {
			    return MetadataObject.State;
			}
			
		}
		private bool ShouldSerializeState() { return false; }
        /// <summary>
        /// Gets or sets the SecurityFilteringBehavior of the Relationship.
        /// </summary>
		[DisplayName("Security Filtering Behavior")]
		[Category("Relationship"),IntelliSense("The Security Filtering Behavior of this Relationship.")]
		public TOM.SecurityFilteringBehavior SecurityFilteringBehavior {
			get {
			    return MetadataObject.SecurityFilteringBehavior;
			}
			set {
				var oldValue = SecurityFilteringBehavior;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("SecurityFilteringBehavior", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.SecurityFilteringBehavior = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "SecurityFilteringBehavior", oldValue, value));
				OnPropertyChanged("SecurityFilteringBehavior", oldValue, value);
			}
		}
		private bool ShouldSerializeSecurityFilteringBehavior() { return false; }
		public Model Parent { 
			get {
				return Handler.WrapperLookup[MetadataObject.Parent] as Model;
			}
		}



		/// <summary>
		/// CTOR - only called from static factory methods on the class
		/// </summary>
		protected Relationship(TOM.Relationship metadataObject, bool init = true) : base(metadataObject)
		{
			if(init) InternalInit();
		}

		private void InternalInit()
		{
		}



		internal override void Undelete(ITabularObjectCollection collection) {
			base.Undelete(collection);
			Reinit();
			ReapplyReferences();
		}

		public override bool Browsable(string propertyName) {
			switch (propertyName) {
				case "Parent":
					return false;
				
				default:
					return base.Browsable(propertyName);
			}
		}

    }


	/// <summary>
	/// Collection class for Relationship. Provides convenient properties for setting a property on multiple objects at once.
	/// </summary>
	public partial class RelationshipCollection: TabularObjectCollection<SingleColumnRelationship, TOM.Relationship, TOM.Model>
	{
		public override TabularNamedObject Parent { get { return Model; } }
		public RelationshipCollection(string collectionName, TOM.RelationshipCollection metadataObjectCollection, Model parent) : base(collectionName, metadataObjectCollection)
		{
		}

		internal override void Reinit() {
			for(int i = 0; i < Count; i++) {
				var item = this[i];
				Handler.WrapperLookup.Remove(item.MetadataObject);
				item.MetadataObject = Model.MetadataObject.Relationships[i] as TOM.SingleColumnRelationship;
				Handler.WrapperLookup.Add(item.MetadataObject, item);
				item.Collection = this;
			}
			MetadataObjectCollection = Model.MetadataObject.Relationships;
			foreach(var item in this) item.Reinit();
		}

		internal override void ReapplyReferences() {
			foreach(var item in this) item.ReapplyReferences();
		}

		/// <summary>
		/// Calling this method will populate the RelationshipCollection with objects based on the MetadataObjects in the corresponding MetadataObjectCollection.
		/// </summary>
		public override void CreateChildrenFromMetadata()
		{
			// Construct child objects (they are automatically added to the Handler's WrapperLookup dictionary):
			foreach(var obj in MetadataObjectCollection) {
				switch((obj as TOM.Relationship).Type) {
					case TOM.RelationshipType.SingleColumn: SingleColumnRelationship.CreateFromMetadata(obj as TOM.SingleColumnRelationship).Collection = this; break;
				}
			}
		}

		[Description("Sets the IsActive property of all objects in the collection at once.")]
		public bool IsActive {
			set {
				if(Handler == null) return;
				Handler.UndoManager.BeginBatch(UndoPropertyChangedAction.GetActionNameFromProperty("IsActive"));
				this.ToList().ForEach(item => { item.IsActive = value; });
				Handler.UndoManager.EndBatch();
			}
		}
		[Description("Sets the CrossFilteringBehavior property of all objects in the collection at once.")]
		public TOM.CrossFilteringBehavior CrossFilteringBehavior {
			set {
				if(Handler == null) return;
				Handler.UndoManager.BeginBatch(UndoPropertyChangedAction.GetActionNameFromProperty("CrossFilteringBehavior"));
				this.ToList().ForEach(item => { item.CrossFilteringBehavior = value; });
				Handler.UndoManager.EndBatch();
			}
		}
		[Description("Sets the JoinOnDateBehavior property of all objects in the collection at once.")]
		public TOM.DateTimeRelationshipBehavior JoinOnDateBehavior {
			set {
				if(Handler == null) return;
				Handler.UndoManager.BeginBatch(UndoPropertyChangedAction.GetActionNameFromProperty("JoinOnDateBehavior"));
				this.ToList().ForEach(item => { item.JoinOnDateBehavior = value; });
				Handler.UndoManager.EndBatch();
			}
		}
		[Description("Sets the RelyOnReferentialIntegrity property of all objects in the collection at once.")]
		public bool RelyOnReferentialIntegrity {
			set {
				if(Handler == null) return;
				Handler.UndoManager.BeginBatch(UndoPropertyChangedAction.GetActionNameFromProperty("RelyOnReferentialIntegrity"));
				this.ToList().ForEach(item => { item.RelyOnReferentialIntegrity = value; });
				Handler.UndoManager.EndBatch();
			}
		}
		[Description("Sets the SecurityFilteringBehavior property of all objects in the collection at once.")]
		public TOM.SecurityFilteringBehavior SecurityFilteringBehavior {
			set {
				if(Handler == null) return;
				Handler.UndoManager.BeginBatch(UndoPropertyChangedAction.GetActionNameFromProperty("SecurityFilteringBehavior"));
				this.ToList().ForEach(item => { item.SecurityFilteringBehavior = value; });
				Handler.UndoManager.EndBatch();
			}
		}

		public override string ToString() {
			return string.Format("({0} {1})", Count, (Count == 1 ? "Relationship" : "Relationships").ToLower());
		}
	}
}
