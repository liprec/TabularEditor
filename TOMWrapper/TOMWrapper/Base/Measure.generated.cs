
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
	/// Base class declaration for Measure
	/// </summary>
	[TypeConverter(typeof(DynamicPropertyConverter))]
	public partial class Measure: TabularNamedObject
			, IDetailObject
			, IHideableObject
			, IErrorMessageObject
			, ITabularTableObject
			, IDescriptionObject
			, IDAXExpressionObject
			, IAnnotationObject
			, IDeletableObject
			, ITabularPerspectiveObject
			, ITranslatableObject
			, IClonableObject
	{
	    protected internal new TOM.Measure MetadataObject { get { return base.MetadataObject as TOM.Measure; } internal set { base.MetadataObject = value; } }

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
        /// Gets or sets the Description of the Measure.
        /// </summary>
		[DisplayName("Description")]
		[Category("Basic"),IntelliSense("The Description of this Measure.")][Editor(typeof(System.ComponentModel.Design.MultilineStringEditor), typeof(System.Drawing.Design.UITypeEditor))]
		public string Description {
			get {
			    return MetadataObject.Description;
			}
			set {
				var oldValue = Description;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("Description", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.Description = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "Description", oldValue, value));
				OnPropertyChanged("Description", oldValue, value);
			}
		}
		private bool ShouldSerializeDescription() { return false; }
        /// <summary>
        /// Gets or sets the DataType of the Measure.
        /// </summary>
		[DisplayName("Data Type")]
		[Category("Metadata"),IntelliSense("The Data Type of this Measure.")]
		public TOM.DataType DataType {
			get {
			    return MetadataObject.DataType;
			}
			
		}
		private bool ShouldSerializeDataType() { return false; }
        /// <summary>
        /// Gets or sets the Expression of the Measure.
        /// </summary>
		[DisplayName("Expression")]
		[Category("Options"),IntelliSense("The Expression of this Measure.")][Editor(typeof(System.ComponentModel.Design.MultilineStringEditor), typeof(System.Drawing.Design.UITypeEditor))]
		public string Expression {
			get {
			    return MetadataObject.Expression;
			}
			set {
				var oldValue = Expression;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("Expression", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.Expression = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "Expression", oldValue, value));
				OnPropertyChanged("Expression", oldValue, value);
			}
		}
		private bool ShouldSerializeExpression() { return false; }
        /// <summary>
        /// Gets or sets the FormatString of the Measure.
        /// </summary>
		[DisplayName("Format String")]
		[Category("Options"),IntelliSense("The Format String of this Measure.")][TypeConverter(typeof(FormatStringConverter))]
		public string FormatString {
			get {
			    return MetadataObject.FormatString;
			}
			set {
				var oldValue = FormatString;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("FormatString", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.FormatString = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "FormatString", oldValue, value));
				OnPropertyChanged("FormatString", oldValue, value);
			}
		}
		private bool ShouldSerializeFormatString() { return false; }
        /// <summary>
        /// Gets or sets the IsHidden of the Measure.
        /// </summary>
		[DisplayName("Hidden")]
		[Category("Basic"),IntelliSense("The Hidden of this Measure.")]
		public bool IsHidden {
			get {
			    return MetadataObject.IsHidden;
			}
			set {
				var oldValue = IsHidden;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("IsHidden", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.IsHidden = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "IsHidden", oldValue, value));
				OnPropertyChanged("IsHidden", oldValue, value);
				Handler.UpdateObject(this);
			}
		}
		private bool ShouldSerializeIsHidden() { return false; }
        /// <summary>
        /// Gets or sets the State of the Measure.
        /// </summary>
		[DisplayName("State")]
		[Category("Metadata"),IntelliSense("The State of this Measure.")]
		public TOM.ObjectState State {
			get {
			    return MetadataObject.State;
			}
			
		}
		private bool ShouldSerializeState() { return false; }
        /// <summary>
        /// Gets or sets the IsSimpleMeasure of the Measure.
        /// </summary>
		[DisplayName("Simple Measure")]
		[Category("Other"),IntelliSense("The Simple Measure of this Measure.")]
		public bool IsSimpleMeasure {
			get {
			    return MetadataObject.IsSimpleMeasure;
			}
			set {
				var oldValue = IsSimpleMeasure;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("IsSimpleMeasure", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.IsSimpleMeasure = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "IsSimpleMeasure", oldValue, value));
				OnPropertyChanged("IsSimpleMeasure", oldValue, value);
			}
		}
		private bool ShouldSerializeIsSimpleMeasure() { return false; }
        /// <summary>
        /// Gets or sets the ErrorMessage of the Measure.
        /// </summary>
		[DisplayName("Error Message")]
		[Category("Metadata"),IntelliSense("The Error Message of this Measure.")]
		public string ErrorMessage {
			get {
			    return MetadataObject.ErrorMessage;
			}
			
		}
		private bool ShouldSerializeErrorMessage() { return false; }
        /// <summary>
        /// Gets or sets the DisplayFolder of the Measure.
        /// </summary>
		[DisplayName("Display Folder")]
		[Category("Basic"),IntelliSense("The Display Folder of this Measure.")][Editor(typeof(CustomDialogEditor), typeof(System.Drawing.Design.UITypeEditor))]
		public string DisplayFolder {
			get {
			    return MetadataObject.DisplayFolder;
			}
			set {
				var oldValue = DisplayFolder;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("DisplayFolder", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.DisplayFolder = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "DisplayFolder", oldValue, value));
				OnPropertyChanged("DisplayFolder", oldValue, value);
				Handler.UpdateFolders(Table);
			}
		}
		private bool ShouldSerializeDisplayFolder() { return false; }
        /// <summary>
        /// Collection of localized Display Folders for this Measure.
        /// </summary>
        [Browsable(true),DisplayName("Display Folders"),Category("Translations and Perspectives")]
	    public TranslationIndexer TranslatedDisplayFolders { private set; get; }
		[Browsable(false)]
		public Table Table
		{ 
			get 
			{ 
				TabularObject t = null;
				if(MetadataObject == null || MetadataObject.Table == null) return null;
				if(!Handler.WrapperLookup.TryGetValue(MetadataObject.Table, out t)) {
				    t = Model.Tables[MetadataObject.Table.Name];
				}
				return t as Table;
			} 
		}
        /// <Summary>
		/// Collection of perspectives in which this Measure is visible.
		/// </Summary>
		[Browsable(true),DisplayName("Perspectives"), Category("Translations and Perspectives")]
        public PerspectiveIndexer InPerspective { get; private set; }
        /// <summary>
        /// Collection of localized descriptions for this Measure.
        /// </summary>
        [Browsable(true),DisplayName("Descriptions"),Category("Translations and Perspectives")]
	    public TranslationIndexer TranslatedDescriptions { private set; get; }
        /// <summary>
        /// Collection of localized names for this Measure.
        /// </summary>
        [Browsable(true),DisplayName("Names"),Category("Translations and Perspectives")]
	    public TranslationIndexer TranslatedNames { private set; get; }


		public static Measure CreateFromMetadata(TOM.Measure metadataObject, bool init = true) {
			var obj = new Measure(metadataObject, init);
			if(init) 
			{
				obj.InternalInit();
				obj.Init();
			}
			return obj;
		}


		/// <summary>
		/// Creates a new Measure and adds it to the parent Table.
		/// Also creates the underlying metadataobject and adds it to the TOM tree.
		/// </summary>
		public static Measure CreateNew(Table parent, string name = null)
		{
			var metadataObject = new TOM.Measure();
			metadataObject.Name = parent.Measures.GetNewName(string.IsNullOrWhiteSpace(name) ? "New Measure" : name);

			var obj = new Measure(metadataObject);

			parent.Measures.Add(obj);
			
			obj.Init();

			return obj;
		}


		/// <summary>
		/// Creates an exact copy of this Measure object.
		/// </summary>
		public Measure Clone(string newName = null, bool includeTranslations = true, Table newParent = null) {
		    Handler.BeginUpdate("Clone Measure");

			// Create a clone of the underlying metadataobject:
			var tom = MetadataObject.Clone() as TOM.Measure;


			// Assign a new, unique name:
			tom.Name = Parent.Measures.MetadataObjectCollection.GetNewName(string.IsNullOrEmpty(newName) ? tom.Name + " copy" : newName);
				
			// Create the TOM Wrapper object, representing the metadataobject (but don't init until after we add it to the parent):
			var obj = CreateFromMetadata(tom, false);

			// Add the object to the parent collection:
			if(newParent != null) 
				newParent.Measures.Add(obj);
			else
    			Parent.Measures.Add(obj);

			obj.InternalInit();
			obj.Init();
			// Copy translations, if applicable:
			if(includeTranslations) {
				// TODO: Copy translations of child objects

				obj.TranslatedNames.CopyFrom(TranslatedNames);
				obj.TranslatedDescriptions.CopyFrom(TranslatedDescriptions);
				obj.TranslatedDisplayFolders.CopyFrom(TranslatedDisplayFolders);
			}
				
			// Copy perspectives:
			obj.InPerspective.CopyFrom(InPerspective);

            Handler.EndUpdate();

            return obj;
		}

		TabularNamedObject IClonableObject.Clone(string newName, bool includeTranslations, TabularNamedObject newParent) 
		{
			return Clone(newName, includeTranslations);
		}

	
        internal override void RenewMetadataObject()
        {
            Handler.WrapperLookup.Remove(MetadataObject);
            MetadataObject = MetadataObject.Clone() as TOM.Measure;
            Handler.WrapperLookup.Add(MetadataObject, this);
        }

		public Table Parent { 
			get {
				return Handler.WrapperLookup[MetadataObject.Parent] as Table;
			}
		}



		/// <summary>
		/// CTOR - only called from static factory methods on the class
		/// </summary>
		protected Measure(TOM.Measure metadataObject, bool init = true) : base(metadataObject)
		{
			if(init) InternalInit();
		}

		private void InternalInit()
		{
			// Create indexers for translations:
			TranslatedNames = new TranslationIndexer(this, TOM.TranslatedProperty.Caption);
			TranslatedDescriptions = new TranslationIndexer(this, TOM.TranslatedProperty.Description);
			TranslatedDisplayFolders = new TranslationIndexer(this, TOM.TranslatedProperty.DisplayFolder);

			// Create indexers for perspectives:
			InPerspective = new PerspectiveMeasureIndexer(this);
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
				
				// Hides translation properties in the grid, unless the model actually contains translations:
				case "TranslatedNames":
				case "TranslatedDescriptions":
				case "TranslatedDisplayFolders":
					return Model.Cultures.Any();
				
				// Hides the perspective property in the grid, unless the model actually contains perspectives:
				case "InPerspective":
					return Model.Perspectives.Any();
				
				default:
					return base.Browsable(propertyName);
			}
		}

    }


	/// <summary>
	/// Collection class for Measure. Provides convenient properties for setting a property on multiple objects at once.
	/// </summary>
	public partial class MeasureCollection: TabularObjectCollection<Measure, TOM.Measure, TOM.Table>
	{
		public override TabularNamedObject Parent { get { return Table; } }
		public Table Table { get; protected set; }
		public MeasureCollection(string collectionName, TOM.MeasureCollection metadataObjectCollection, Table parent) : base(collectionName, metadataObjectCollection)
		{
			Table = parent;
		}

		internal override void Reinit() {
			for(int i = 0; i < Count; i++) {
				var item = this[i];
				Handler.WrapperLookup.Remove(item.MetadataObject);
				item.MetadataObject = Table.MetadataObject.Measures[i] as TOM.Measure;
				Handler.WrapperLookup.Add(item.MetadataObject, item);
				item.Collection = this;
			}
			MetadataObjectCollection = Table.MetadataObject.Measures;
			foreach(var item in this) item.Reinit();
		}

		internal override void ReapplyReferences() {
			foreach(var item in this) item.ReapplyReferences();
		}

		/// <summary>
		/// Calling this method will populate the MeasureCollection with objects based on the MetadataObjects in the corresponding MetadataObjectCollection.
		/// </summary>
		public override void CreateChildrenFromMetadata()
		{
			// Construct child objects (they are automatically added to the Handler's WrapperLookup dictionary):
			foreach(var obj in MetadataObjectCollection) {
				Measure.CreateFromMetadata(obj).Collection = this;
			}
		}

		[Description("Sets the Description property of all objects in the collection at once.")]
		public string Description {
			set {
				if(Handler == null) return;
				Handler.UndoManager.BeginBatch(UndoPropertyChangedAction.GetActionNameFromProperty("Description"));
				this.ToList().ForEach(item => { item.Description = value; });
				Handler.UndoManager.EndBatch();
			}
		}
		[Description("Sets the Expression property of all objects in the collection at once.")]
		public string Expression {
			set {
				if(Handler == null) return;
				Handler.UndoManager.BeginBatch(UndoPropertyChangedAction.GetActionNameFromProperty("Expression"));
				this.ToList().ForEach(item => { item.Expression = value; });
				Handler.UndoManager.EndBatch();
			}
		}
		[Description("Sets the FormatString property of all objects in the collection at once.")]
		public string FormatString {
			set {
				if(Handler == null) return;
				Handler.UndoManager.BeginBatch(UndoPropertyChangedAction.GetActionNameFromProperty("FormatString"));
				this.ToList().ForEach(item => { item.FormatString = value; });
				Handler.UndoManager.EndBatch();
			}
		}
		[Description("Sets the IsHidden property of all objects in the collection at once.")]
		public bool IsHidden {
			set {
				if(Handler == null) return;
				Handler.UndoManager.BeginBatch(UndoPropertyChangedAction.GetActionNameFromProperty("IsHidden"));
				this.ToList().ForEach(item => { item.IsHidden = value; });
				Handler.UndoManager.EndBatch();
			}
		}
		[Description("Sets the IsSimpleMeasure property of all objects in the collection at once.")]
		public bool IsSimpleMeasure {
			set {
				if(Handler == null) return;
				Handler.UndoManager.BeginBatch(UndoPropertyChangedAction.GetActionNameFromProperty("IsSimpleMeasure"));
				this.ToList().ForEach(item => { item.IsSimpleMeasure = value; });
				Handler.UndoManager.EndBatch();
			}
		}
		[Description("Sets the DisplayFolder property of all objects in the collection at once.")]
		public string DisplayFolder {
			set {
				if(Handler == null) return;
				Handler.UndoManager.BeginBatch(UndoPropertyChangedAction.GetActionNameFromProperty("DisplayFolder"));
				this.ToList().ForEach(item => { item.DisplayFolder = value; });
				Handler.UndoManager.EndBatch();
			}
		}
		[Description("Sets the KPI property of all objects in the collection at once.")]
		public KPI KPI {
			set {
				if(Handler == null) return;
				Handler.UndoManager.BeginBatch(UndoPropertyChangedAction.GetActionNameFromProperty("KPI"));
				this.ToList().ForEach(item => { item.KPI = value; });
				Handler.UndoManager.EndBatch();
			}
		}

		public override string ToString() {
			return string.Format("({0} {1})", Count, (Count == 1 ? "Measure" : "Measures").ToLower());
		}
	}
}
