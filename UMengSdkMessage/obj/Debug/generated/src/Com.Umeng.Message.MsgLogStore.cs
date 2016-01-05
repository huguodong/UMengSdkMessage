using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgLogStore']"
	[global::Android.Runtime.Register ("com/umeng/message/MsgLogStore", DoNotGenerateAcw=true)]
	public partial class MsgLogStore : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgLogStore']/field[@name='ActionType']"
		[Register ("ActionType")]
		public const string ActionType = (string) "ActionType";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgLogStore']/field[@name='MsgId']"
		[Register ("MsgId")]
		public const string MsgId = (string) "MsgId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgLogStore']/field[@name='MsgType']"
		[Register ("MsgType")]
		public const string MsgType = (string) "MsgType";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgLogStore']/field[@name='Time']"
		[Register ("Time")]
		public const string Time = (string) "Time";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgLogStore.MsgLog']"
		[global::Android.Runtime.Register ("com/umeng/message/MsgLogStore$MsgLog", DoNotGenerateAcw=true)]
		public partial class MsgLog : global::Java.Lang.Object {


			static IntPtr actionType_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgLogStore.MsgLog']/field[@name='actionType']"
			[Register ("actionType")]
			public int ActionType {
				get {
					if (actionType_jfieldId == IntPtr.Zero)
						actionType_jfieldId = JNIEnv.GetFieldID (class_ref, "actionType", "I");
					return JNIEnv.GetIntField (Handle, actionType_jfieldId);
				}
				set {
					if (actionType_jfieldId == IntPtr.Zero)
						actionType_jfieldId = JNIEnv.GetFieldID (class_ref, "actionType", "I");
					JNIEnv.SetField (Handle, actionType_jfieldId, value);
				}
			}

			static IntPtr msgId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgLogStore.MsgLog']/field[@name='msgId']"
			[Register ("msgId")]
			public string MsgId {
				get {
					if (msgId_jfieldId == IntPtr.Zero)
						msgId_jfieldId = JNIEnv.GetFieldID (class_ref, "msgId", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, msgId_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (msgId_jfieldId == IntPtr.Zero)
						msgId_jfieldId = JNIEnv.GetFieldID (class_ref, "msgId", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					JNIEnv.SetField (Handle, msgId_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr time_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgLogStore.MsgLog']/field[@name='time']"
			[Register ("time")]
			public long Time {
				get {
					if (time_jfieldId == IntPtr.Zero)
						time_jfieldId = JNIEnv.GetFieldID (class_ref, "time", "J");
					return JNIEnv.GetLongField (Handle, time_jfieldId);
				}
				set {
					if (time_jfieldId == IntPtr.Zero)
						time_jfieldId = JNIEnv.GetFieldID (class_ref, "time", "J");
					JNIEnv.SetField (Handle, time_jfieldId, value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/umeng/message/MsgLogStore$MsgLog", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MsgLog); }
			}

			protected MsgLog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_umeng_message_MsgLogStore_Ljava_lang_String_IJ;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgLogStore.MsgLog']/constructor[@name='MsgLogStore.MsgLog' and count(parameter)=4 and parameter[1][@type='com.umeng.message.MsgLogStore'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
			[Register (".ctor", "(Lcom/umeng/message/MsgLogStore;Ljava/lang/String;IJ)V", "")]
			public MsgLog (global::Com.Umeng.Message.MsgLogStore __self, string p1, int p2, long p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);;
				if (GetType () != typeof (MsgLog)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;IJ)V", new JValue (__self), new JValue (native_p1), new JValue (p2), new JValue (p3)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;IJ)V", new JValue (__self), new JValue (native_p1), new JValue (p2), new JValue (p3));
					JNIEnv.DeleteLocalRef (native_p1);
					return;
				}

				if (id_ctor_Lcom_umeng_message_MsgLogStore_Ljava_lang_String_IJ == IntPtr.Zero)
					id_ctor_Lcom_umeng_message_MsgLogStore_Ljava_lang_String_IJ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/umeng/message/MsgLogStore;Ljava/lang/String;IJ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_umeng_message_MsgLogStore_Ljava_lang_String_IJ, new JValue (__self), new JValue (native_p1), new JValue (p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_umeng_message_MsgLogStore_Ljava_lang_String_IJ, new JValue (__self), new JValue (native_p1), new JValue (p2), new JValue (p3));
				JNIEnv.DeleteLocalRef (native_p1);
			}

			static IntPtr id_ctor_Lcom_umeng_message_MsgLogStore_Landroid_database_Cursor_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgLogStore.MsgLog']/constructor[@name='MsgLogStore.MsgLog' and count(parameter)=2 and parameter[1][@type='com.umeng.message.MsgLogStore'] and parameter[2][@type='android.database.Cursor']]"
			[Register (".ctor", "(Lcom/umeng/message/MsgLogStore;Landroid/database/Cursor;)V", "")]
			public MsgLog (global::Com.Umeng.Message.MsgLogStore __self, global::Android.Database.ICursor p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (MsgLog)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/database/Cursor;)V", new JValue (__self), new JValue (p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/database/Cursor;)V", new JValue (__self), new JValue (p1));
					return;
				}

				if (id_ctor_Lcom_umeng_message_MsgLogStore_Landroid_database_Cursor_ == IntPtr.Zero)
					id_ctor_Lcom_umeng_message_MsgLogStore_Landroid_database_Cursor_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/umeng/message/MsgLogStore;Landroid/database/Cursor;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_umeng_message_MsgLogStore_Landroid_database_Cursor_, new JValue (__self), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_umeng_message_MsgLogStore_Landroid_database_Cursor_, new JValue (__self), new JValue (p1));
			}

			static Delegate cb_getContentValues;
#pragma warning disable 0169
			static Delegate GetGetContentValuesHandler ()
			{
				if (cb_getContentValues == null)
					cb_getContentValues = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentValues);
				return cb_getContentValues;
			}

			static IntPtr n_GetContentValues (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Message.MsgLogStore.MsgLog __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MsgLogStore.MsgLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ContentValues);
			}
#pragma warning restore 0169

			static IntPtr id_getContentValues;
			public virtual global::Android.Content.ContentValues ContentValues {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgLogStore.MsgLog']/method[@name='getContentValues' and count(parameter)=0]"
				[Register ("getContentValues", "()Landroid/content/ContentValues;", "GetGetContentValuesHandler")]
				get {
					if (id_getContentValues == IntPtr.Zero)
						id_getContentValues = JNIEnv.GetMethodID (class_ref, "getContentValues", "()Landroid/content/ContentValues;");

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (JNIEnv.CallObjectMethod  (Handle, id_getContentValues), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentValues", "()Landroid/content/ContentValues;")), JniHandleOwnership.TransferLocalRef);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgLogStore.MsgLogIdType']"
		[global::Android.Runtime.Register ("com/umeng/message/MsgLogStore$MsgLogIdType", DoNotGenerateAcw=true)]
		public partial class MsgLogIdType : global::Java.Lang.Object {


			static IntPtr msgId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgLogStore.MsgLogIdType']/field[@name='msgId']"
			[Register ("msgId")]
			public string MsgId {
				get {
					if (msgId_jfieldId == IntPtr.Zero)
						msgId_jfieldId = JNIEnv.GetFieldID (class_ref, "msgId", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, msgId_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (msgId_jfieldId == IntPtr.Zero)
						msgId_jfieldId = JNIEnv.GetFieldID (class_ref, "msgId", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					JNIEnv.SetField (Handle, msgId_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr msgType_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgLogStore.MsgLogIdType']/field[@name='msgType']"
			[Register ("msgType")]
			public string MsgType {
				get {
					if (msgType_jfieldId == IntPtr.Zero)
						msgType_jfieldId = JNIEnv.GetFieldID (class_ref, "msgType", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, msgType_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (msgType_jfieldId == IntPtr.Zero)
						msgType_jfieldId = JNIEnv.GetFieldID (class_ref, "msgType", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					JNIEnv.SetField (Handle, msgType_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/umeng/message/MsgLogStore$MsgLogIdType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MsgLogIdType); }
			}

			protected MsgLogIdType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_umeng_message_MsgLogStore_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgLogStore.MsgLogIdType']/constructor[@name='MsgLogStore.MsgLogIdType' and count(parameter)=3 and parameter[1][@type='com.umeng.message.MsgLogStore'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/umeng/message/MsgLogStore;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public MsgLogIdType (global::Com.Umeng.Message.MsgLogStore __self, string p1, string p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);;
				IntPtr native_p2 = JNIEnv.NewString (p2);;
				if (GetType () != typeof (MsgLogIdType)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Ljava/lang/String;)V", new JValue (__self), new JValue (native_p1), new JValue (native_p2)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Ljava/lang/String;)V", new JValue (__self), new JValue (native_p1), new JValue (native_p2));
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
					return;
				}

				if (id_ctor_Lcom_umeng_message_MsgLogStore_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_umeng_message_MsgLogStore_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/umeng/message/MsgLogStore;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_umeng_message_MsgLogStore_Ljava_lang_String_Ljava_lang_String_, new JValue (__self), new JValue (native_p1), new JValue (native_p2)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_umeng_message_MsgLogStore_Ljava_lang_String_Ljava_lang_String_, new JValue (__self), new JValue (native_p1), new JValue (native_p2));
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}

			static IntPtr id_ctor_Lcom_umeng_message_MsgLogStore_Landroid_database_Cursor_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgLogStore.MsgLogIdType']/constructor[@name='MsgLogStore.MsgLogIdType' and count(parameter)=2 and parameter[1][@type='com.umeng.message.MsgLogStore'] and parameter[2][@type='android.database.Cursor']]"
			[Register (".ctor", "(Lcom/umeng/message/MsgLogStore;Landroid/database/Cursor;)V", "")]
			public MsgLogIdType (global::Com.Umeng.Message.MsgLogStore __self, global::Android.Database.ICursor p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (MsgLogIdType)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/database/Cursor;)V", new JValue (__self), new JValue (p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/database/Cursor;)V", new JValue (__self), new JValue (p1));
					return;
				}

				if (id_ctor_Lcom_umeng_message_MsgLogStore_Landroid_database_Cursor_ == IntPtr.Zero)
					id_ctor_Lcom_umeng_message_MsgLogStore_Landroid_database_Cursor_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/umeng/message/MsgLogStore;Landroid/database/Cursor;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_umeng_message_MsgLogStore_Landroid_database_Cursor_, new JValue (__self), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_umeng_message_MsgLogStore_Landroid_database_Cursor_, new JValue (__self), new JValue (p1));
			}

			static Delegate cb_getContentValues;
#pragma warning disable 0169
			static Delegate GetGetContentValuesHandler ()
			{
				if (cb_getContentValues == null)
					cb_getContentValues = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentValues);
				return cb_getContentValues;
			}

			static IntPtr n_GetContentValues (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Message.MsgLogStore.MsgLogIdType __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MsgLogStore.MsgLogIdType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ContentValues);
			}
#pragma warning restore 0169

			static IntPtr id_getContentValues;
			public virtual global::Android.Content.ContentValues ContentValues {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgLogStore.MsgLogIdType']/method[@name='getContentValues' and count(parameter)=0]"
				[Register ("getContentValues", "()Landroid/content/ContentValues;", "GetGetContentValuesHandler")]
				get {
					if (id_getContentValues == IntPtr.Zero)
						id_getContentValues = JNIEnv.GetMethodID (class_ref, "getContentValues", "()Landroid/content/ContentValues;");

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (JNIEnv.CallObjectMethod  (Handle, id_getContentValues), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentValues", "()Landroid/content/ContentValues;")), JniHandleOwnership.TransferLocalRef);
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/MsgLogStore", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MsgLogStore); }
		}

		protected MsgLogStore (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getMsgLogIdTypes;
#pragma warning disable 0169
		static Delegate GetGetMsgLogIdTypesHandler ()
		{
			if (cb_getMsgLogIdTypes == null)
				cb_getMsgLogIdTypes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMsgLogIdTypes);
			return cb_getMsgLogIdTypes;
		}

		static IntPtr n_GetMsgLogIdTypes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.MsgLogStore __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MsgLogStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Umeng.Message.MsgLogStore.MsgLogIdType>.ToLocalJniHandle (__this.MsgLogIdTypes);
		}
#pragma warning restore 0169

		static IntPtr id_getMsgLogIdTypes;
		public virtual global::System.Collections.Generic.IList<global::Com.Umeng.Message.MsgLogStore.MsgLogIdType> MsgLogIdTypes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgLogStore']/method[@name='getMsgLogIdTypes' and count(parameter)=0]"
			[Register ("getMsgLogIdTypes", "()Ljava/util/ArrayList;", "GetGetMsgLogIdTypesHandler")]
			get {
				if (id_getMsgLogIdTypes == IntPtr.Zero)
					id_getMsgLogIdTypes = JNIEnv.GetMethodID (class_ref, "getMsgLogIdTypes", "()Ljava/util/ArrayList;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Com.Umeng.Message.MsgLogStore.MsgLogIdType>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getMsgLogIdTypes), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Com.Umeng.Message.MsgLogStore.MsgLogIdType>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMsgLogIdTypes", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_addLog_Ljava_lang_String_IJ;
#pragma warning disable 0169
		static Delegate GetAddLog_Ljava_lang_String_IJHandler ()
		{
			if (cb_addLog_Ljava_lang_String_IJ == null)
				cb_addLog_Ljava_lang_String_IJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, long, bool>) n_AddLog_Ljava_lang_String_IJ);
			return cb_addLog_Ljava_lang_String_IJ;
		}

		static bool n_AddLog_Ljava_lang_String_IJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, long p2)
		{
			global::Com.Umeng.Message.MsgLogStore __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MsgLogStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddLog (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addLog_Ljava_lang_String_IJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgLogStore']/method[@name='addLog' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='long']]"
		[Register ("addLog", "(Ljava/lang/String;IJ)Z", "GetAddLog_Ljava_lang_String_IJHandler")]
		public virtual bool AddLog (string p0, int p1, long p2)
		{
			if (id_addLog_Ljava_lang_String_IJ == IntPtr.Zero)
				id_addLog_Ljava_lang_String_IJ = JNIEnv.GetMethodID (class_ref, "addLog", "(Ljava/lang/String;IJ)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_addLog_Ljava_lang_String_IJ, new JValue (native_p0), new JValue (p1), new JValue (p2));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addLog", "(Ljava/lang/String;IJ)Z"), new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_addLogIdType_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddLogIdType_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addLogIdType_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addLogIdType_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_AddLogIdType_Ljava_lang_String_Ljava_lang_String_);
			return cb_addLogIdType_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_AddLogIdType_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Message.MsgLogStore __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MsgLogStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddLogIdType (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addLogIdType_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgLogStore']/method[@name='addLogIdType' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addLogIdType", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetAddLogIdType_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual bool AddLogIdType (string p0, string p1)
		{
			if (id_addLogIdType_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addLogIdType_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addLogIdType", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_addLogIdType_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addLogIdType", "(Ljava/lang/String;Ljava/lang/String;)Z"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgLogStore']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/umeng/message/MsgLogStore;", "")]
		public static global::Com.Umeng.Message.MsgLogStore GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lcom/umeng/message/MsgLogStore;");
			global::Com.Umeng.Message.MsgLogStore __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MsgLogStore> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getMsgLog_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMsgLog_Ljava_lang_String_Handler ()
		{
			if (cb_getMsgLog_Ljava_lang_String_ == null)
				cb_getMsgLog_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMsgLog_Ljava_lang_String_);
			return cb_getMsgLog_Ljava_lang_String_;
		}

		static IntPtr n_GetMsgLog_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.MsgLogStore __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MsgLogStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMsgLog (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMsgLog_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgLogStore']/method[@name='getMsgLog' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getMsgLog", "(Ljava/lang/String;)Lcom/umeng/message/MsgLogStore$MsgLog;", "GetGetMsgLog_Ljava_lang_String_Handler")]
		public virtual global::Com.Umeng.Message.MsgLogStore.MsgLog GetMsgLog (string p0)
		{
			if (id_getMsgLog_Ljava_lang_String_ == IntPtr.Zero)
				id_getMsgLog_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getMsgLog", "(Ljava/lang/String;)Lcom/umeng/message/MsgLogStore$MsgLog;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Umeng.Message.MsgLogStore.MsgLog __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MsgLogStore.MsgLog> (JNIEnv.CallObjectMethod  (Handle, id_getMsgLog_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MsgLogStore.MsgLog> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMsgLog", "(Ljava/lang/String;)Lcom/umeng/message/MsgLogStore$MsgLog;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getMsgLogIdTypes_I;
#pragma warning disable 0169
		static Delegate GetGetMsgLogIdTypes_IHandler ()
		{
			if (cb_getMsgLogIdTypes_I == null)
				cb_getMsgLogIdTypes_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetMsgLogIdTypes_I);
			return cb_getMsgLogIdTypes_I;
		}

		static IntPtr n_GetMsgLogIdTypes_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Umeng.Message.MsgLogStore __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MsgLogStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Umeng.Message.MsgLogStore.MsgLogIdType>.ToLocalJniHandle (__this.GetMsgLogIdTypes (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getMsgLogIdTypes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgLogStore']/method[@name='getMsgLogIdTypes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getMsgLogIdTypes", "(I)Ljava/util/ArrayList;", "GetGetMsgLogIdTypes_IHandler")]
		public virtual global::System.Collections.Generic.IList<global::Com.Umeng.Message.MsgLogStore.MsgLogIdType> GetMsgLogIdTypes (int p0)
		{
			if (id_getMsgLogIdTypes_I == IntPtr.Zero)
				id_getMsgLogIdTypes_I = JNIEnv.GetMethodID (class_ref, "getMsgLogIdTypes", "(I)Ljava/util/ArrayList;");

			if (GetType () == ThresholdType)
				return global::Android.Runtime.JavaList<global::Com.Umeng.Message.MsgLogStore.MsgLogIdType>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getMsgLogIdTypes_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Android.Runtime.JavaList<global::Com.Umeng.Message.MsgLogStore.MsgLogIdType>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMsgLogIdTypes", "(I)Ljava/util/ArrayList;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getMsgLogs_I;
#pragma warning disable 0169
		static Delegate GetGetMsgLogs_IHandler ()
		{
			if (cb_getMsgLogs_I == null)
				cb_getMsgLogs_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetMsgLogs_I);
			return cb_getMsgLogs_I;
		}

		static IntPtr n_GetMsgLogs_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Umeng.Message.MsgLogStore __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MsgLogStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Umeng.Message.MsgLogStore.MsgLog>.ToLocalJniHandle (__this.GetMsgLogs (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getMsgLogs_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgLogStore']/method[@name='getMsgLogs' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getMsgLogs", "(I)Ljava/util/ArrayList;", "GetGetMsgLogs_IHandler")]
		public virtual global::System.Collections.Generic.IList<global::Com.Umeng.Message.MsgLogStore.MsgLog> GetMsgLogs (int p0)
		{
			if (id_getMsgLogs_I == IntPtr.Zero)
				id_getMsgLogs_I = JNIEnv.GetMethodID (class_ref, "getMsgLogs", "(I)Ljava/util/ArrayList;");

			if (GetType () == ThresholdType)
				return global::Android.Runtime.JavaList<global::Com.Umeng.Message.MsgLogStore.MsgLog>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getMsgLogs_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Android.Runtime.JavaList<global::Com.Umeng.Message.MsgLogStore.MsgLog>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMsgLogs", "(I)Ljava/util/ArrayList;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_removeLog_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetRemoveLog_Ljava_lang_String_IHandler ()
		{
			if (cb_removeLog_Ljava_lang_String_I == null)
				cb_removeLog_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, bool>) n_RemoveLog_Ljava_lang_String_I);
			return cb_removeLog_Ljava_lang_String_I;
		}

		static bool n_RemoveLog_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Umeng.Message.MsgLogStore __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MsgLogStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveLog (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeLog_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgLogStore']/method[@name='removeLog' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("removeLog", "(Ljava/lang/String;I)Z", "GetRemoveLog_Ljava_lang_String_IHandler")]
		public virtual bool RemoveLog (string p0, int p1)
		{
			if (id_removeLog_Ljava_lang_String_I == IntPtr.Zero)
				id_removeLog_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "removeLog", "(Ljava/lang/String;I)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_removeLog_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeLog", "(Ljava/lang/String;I)Z"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_removeLogIdType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveLogIdType_Ljava_lang_String_Handler ()
		{
			if (cb_removeLogIdType_Ljava_lang_String_ == null)
				cb_removeLogIdType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveLogIdType_Ljava_lang_String_);
			return cb_removeLogIdType_Ljava_lang_String_;
		}

		static bool n_RemoveLogIdType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.MsgLogStore __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MsgLogStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveLogIdType (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeLogIdType_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgLogStore']/method[@name='removeLogIdType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeLogIdType", "(Ljava/lang/String;)Z", "GetRemoveLogIdType_Ljava_lang_String_Handler")]
		public virtual bool RemoveLogIdType (string p0)
		{
			if (id_removeLogIdType_Ljava_lang_String_ == IntPtr.Zero)
				id_removeLogIdType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeLogIdType", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_removeLogIdType_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeLogIdType", "(Ljava/lang/String;)Z"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
