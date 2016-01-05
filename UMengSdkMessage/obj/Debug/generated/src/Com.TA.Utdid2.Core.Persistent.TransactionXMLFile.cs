using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.TA.Utdid2.Core.Persistent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='TransactionXMLFile']"
	[global::Android.Runtime.Register ("com/ta/utdid2/core/persistent/TransactionXMLFile", DoNotGenerateAcw=true)]
	public partial class TransactionXMLFile : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='TransactionXMLFile']/field[@name='MODE_PRIVATE']"
		[Register ("MODE_PRIVATE")]
		public const int ModePrivate = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='TransactionXMLFile']/field[@name='MODE_WORLD_READABLE']"
		[Register ("MODE_WORLD_READABLE")]
		public const int ModeWorldReadable = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='TransactionXMLFile']/field[@name='MODE_WORLD_WRITEABLE']"
		[Register ("MODE_WORLD_WRITEABLE")]
		public const int ModeWorldWriteable = (int) 2;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='TransactionXMLFile.MySharedPreferencesImpl']"
		[global::Android.Runtime.Register ("com/ta/utdid2/core/persistent/TransactionXMLFile$MySharedPreferencesImpl", DoNotGenerateAcw=true)]
		public sealed partial class MySharedPreferencesImpl : global::Java.Lang.Object, global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferences {

			// Metadata.xml XPath class reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='TransactionXMLFile.MySharedPreferencesImpl.EditorImpl']"
			[global::Android.Runtime.Register ("com/ta/utdid2/core/persistent/TransactionXMLFile$MySharedPreferencesImpl$EditorImpl", DoNotGenerateAcw=true)]
			public sealed partial class EditorImpl : global::Java.Lang.Object, global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor {

				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/ta/utdid2/core/persistent/TransactionXMLFile$MySharedPreferencesImpl$EditorImpl", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (EditorImpl); }
				}

				internal EditorImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static IntPtr id_ctor_Lcom_ta_utdid2_core_persistent_TransactionXMLFile_MySharedPreferencesImpl_;
				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='TransactionXMLFile.MySharedPreferencesImpl.EditorImpl']/constructor[@name='TransactionXMLFile.MySharedPreferencesImpl.EditorImpl' and count(parameter)=1 and parameter[1][@type='com.ta.utdid2.core.persistent.TransactionXMLFile.MySharedPreferencesImpl']]"
				[Register (".ctor", "(Lcom/ta/utdid2/core/persistent/TransactionXMLFile$MySharedPreferencesImpl;)V", "")]
				public EditorImpl (global::Com.TA.Utdid2.Core.Persistent.TransactionXMLFile.MySharedPreferencesImpl __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
				{
					if (Handle != IntPtr.Zero)
						return;

					if (GetType () != typeof (EditorImpl)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self)),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self));
						return;
					}

					if (id_ctor_Lcom_ta_utdid2_core_persistent_TransactionXMLFile_MySharedPreferencesImpl_ == IntPtr.Zero)
						id_ctor_Lcom_ta_utdid2_core_persistent_TransactionXMLFile_MySharedPreferencesImpl_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/ta/utdid2/core/persistent/TransactionXMLFile$MySharedPreferencesImpl;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_ta_utdid2_core_persistent_TransactionXMLFile_MySharedPreferencesImpl_, new JValue (__self)),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_ta_utdid2_core_persistent_TransactionXMLFile_MySharedPreferencesImpl_, new JValue (__self));
				}

				static IntPtr id_clear;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='TransactionXMLFile.MySharedPreferencesImpl.EditorImpl']/method[@name='clear' and count(parameter)=0]"
				[Register ("clear", "()Lcom/ta/utdid2/core/persistent/MySharedPreferences$MyEditor;", "")]
				public global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor Clear ()
				{
					if (id_clear == IntPtr.Zero)
						id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()Lcom/ta/utdid2/core/persistent/MySharedPreferences$MyEditor;");
					return global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor> (JNIEnv.CallObjectMethod  (Handle, id_clear), JniHandleOwnership.TransferLocalRef);
				}

				static IntPtr id_commit;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='TransactionXMLFile.MySharedPreferencesImpl.EditorImpl']/method[@name='commit' and count(parameter)=0]"
				[Register ("commit", "()Z", "")]
				public bool Commit ()
				{
					if (id_commit == IntPtr.Zero)
						id_commit = JNIEnv.GetMethodID (class_ref, "commit", "()Z");
					return JNIEnv.CallBooleanMethod  (Handle, id_commit);
				}

				static IntPtr id_putBoolean_Ljava_lang_String_Z;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='TransactionXMLFile.MySharedPreferencesImpl.EditorImpl']/method[@name='putBoolean' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
				[Register ("putBoolean", "(Ljava/lang/String;Z)Lcom/ta/utdid2/core/persistent/MySharedPreferences$MyEditor;", "")]
				public global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor PutBoolean (string p0, bool p1)
				{
					if (id_putBoolean_Ljava_lang_String_Z == IntPtr.Zero)
						id_putBoolean_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "putBoolean", "(Ljava/lang/String;Z)Lcom/ta/utdid2/core/persistent/MySharedPreferences$MyEditor;");
					IntPtr native_p0 = JNIEnv.NewString (p0);
					global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor __ret = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor> (JNIEnv.CallObjectMethod  (Handle, id_putBoolean_Ljava_lang_String_Z, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					return __ret;
				}

				static IntPtr id_putFloat_Ljava_lang_String_F;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='TransactionXMLFile.MySharedPreferencesImpl.EditorImpl']/method[@name='putFloat' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float']]"
				[Register ("putFloat", "(Ljava/lang/String;F)Lcom/ta/utdid2/core/persistent/MySharedPreferences$MyEditor;", "")]
				public global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor PutFloat (string p0, float p1)
				{
					if (id_putFloat_Ljava_lang_String_F == IntPtr.Zero)
						id_putFloat_Ljava_lang_String_F = JNIEnv.GetMethodID (class_ref, "putFloat", "(Ljava/lang/String;F)Lcom/ta/utdid2/core/persistent/MySharedPreferences$MyEditor;");
					IntPtr native_p0 = JNIEnv.NewString (p0);
					global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor __ret = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor> (JNIEnv.CallObjectMethod  (Handle, id_putFloat_Ljava_lang_String_F, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					return __ret;
				}

				static IntPtr id_putInt_Ljava_lang_String_I;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='TransactionXMLFile.MySharedPreferencesImpl.EditorImpl']/method[@name='putInt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
				[Register ("putInt", "(Ljava/lang/String;I)Lcom/ta/utdid2/core/persistent/MySharedPreferences$MyEditor;", "")]
				public global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor PutInt (string p0, int p1)
				{
					if (id_putInt_Ljava_lang_String_I == IntPtr.Zero)
						id_putInt_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "putInt", "(Ljava/lang/String;I)Lcom/ta/utdid2/core/persistent/MySharedPreferences$MyEditor;");
					IntPtr native_p0 = JNIEnv.NewString (p0);
					global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor __ret = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor> (JNIEnv.CallObjectMethod  (Handle, id_putInt_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					return __ret;
				}

				static IntPtr id_putLong_Ljava_lang_String_J;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='TransactionXMLFile.MySharedPreferencesImpl.EditorImpl']/method[@name='putLong' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
				[Register ("putLong", "(Ljava/lang/String;J)Lcom/ta/utdid2/core/persistent/MySharedPreferences$MyEditor;", "")]
				public global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor PutLong (string p0, long p1)
				{
					if (id_putLong_Ljava_lang_String_J == IntPtr.Zero)
						id_putLong_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "putLong", "(Ljava/lang/String;J)Lcom/ta/utdid2/core/persistent/MySharedPreferences$MyEditor;");
					IntPtr native_p0 = JNIEnv.NewString (p0);
					global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor __ret = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor> (JNIEnv.CallObjectMethod  (Handle, id_putLong_Ljava_lang_String_J, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					return __ret;
				}

				static IntPtr id_putString_Ljava_lang_String_Ljava_lang_String_;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='TransactionXMLFile.MySharedPreferencesImpl.EditorImpl']/method[@name='putString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
				[Register ("putString", "(Ljava/lang/String;Ljava/lang/String;)Lcom/ta/utdid2/core/persistent/MySharedPreferences$MyEditor;", "")]
				public global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor PutString (string p0, string p1)
				{
					if (id_putString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
						id_putString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "putString", "(Ljava/lang/String;Ljava/lang/String;)Lcom/ta/utdid2/core/persistent/MySharedPreferences$MyEditor;");
					IntPtr native_p0 = JNIEnv.NewString (p0);
					IntPtr native_p1 = JNIEnv.NewString (p1);
					global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor __ret = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor> (JNIEnv.CallObjectMethod  (Handle, id_putString_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
					return __ret;
				}

				static IntPtr id_remove_Ljava_lang_String_;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='TransactionXMLFile.MySharedPreferencesImpl.EditorImpl']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("remove", "(Ljava/lang/String;)Lcom/ta/utdid2/core/persistent/MySharedPreferences$MyEditor;", "")]
				public global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor Remove (string p0)
				{
					if (id_remove_Ljava_lang_String_ == IntPtr.Zero)
						id_remove_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/String;)Lcom/ta/utdid2/core/persistent/MySharedPreferences$MyEditor;");
					IntPtr native_p0 = JNIEnv.NewString (p0);
					global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor __ret = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor> (JNIEnv.CallObjectMethod  (Handle, id_remove_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					return __ret;
				}

			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ta/utdid2/core/persistent/TransactionXMLFile$MySharedPreferencesImpl", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MySharedPreferencesImpl); }
			}

			internal MySharedPreferencesImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getAll;
			public global::System.Collections.Generic.IDictionary<string, object> All {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='TransactionXMLFile.MySharedPreferencesImpl']/method[@name='getAll' and count(parameter)=0]"
				[Register ("getAll", "()Ljava/util/Map;", "GetGetAllHandler")]
				get {
					if (id_getAll == IntPtr.Zero)
						id_getAll = JNIEnv.GetMethodID (class_ref, "getAll", "()Ljava/util/Map;");
					return global::Android.Runtime.JavaDictionary<string, object>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getAll), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_a;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='TransactionXMLFile.MySharedPreferencesImpl']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()Z", "")]
			public bool A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetMethodID (class_ref, "a", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_a);
			}

			static IntPtr id_a_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='TransactionXMLFile.MySharedPreferencesImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("a", "(Z)V", "")]
			public void A (bool p0)
			{
				if (id_a_Z == IntPtr.Zero)
					id_a_Z = JNIEnv.GetMethodID (class_ref, "a", "(Z)V");
				JNIEnv.CallVoidMethod  (Handle, id_a_Z, new JValue (p0));
			}

			static IntPtr id_a_Ljava_util_Map_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='TransactionXMLFile.MySharedPreferencesImpl']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
			[Register ("a", "(Ljava/util/Map;)V", "")]
			public void A (global::System.Collections.IDictionary p0)
			{
				if (id_a_Ljava_util_Map_ == IntPtr.Zero)
					id_a_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/Map;)V");
				IntPtr native_p0 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p0);
				JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_util_Map_, new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static IntPtr id_checkFile;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='TransactionXMLFile.MySharedPreferencesImpl']/method[@name='checkFile' and count(parameter)=0]"
			[Register ("checkFile", "()Z", "")]
			public bool CheckFile ()
			{
				if (id_checkFile == IntPtr.Zero)
					id_checkFile = JNIEnv.GetMethodID (class_ref, "checkFile", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_checkFile);
			}

			static IntPtr id_contains_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='TransactionXMLFile.MySharedPreferencesImpl']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("contains", "(Ljava/lang/String;)Z", "")]
			public bool Contains (string p0)
			{
				if (id_contains_Ljava_lang_String_ == IntPtr.Zero)
					id_contains_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "contains", "(Ljava/lang/String;)Z");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_contains_Ljava_lang_String_, new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_edit;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='TransactionXMLFile.MySharedPreferencesImpl']/method[@name='edit' and count(parameter)=0]"
			[Register ("edit", "()Lcom/ta/utdid2/core/persistent/MySharedPreferences$MyEditor;", "")]
			public global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor Edit ()
			{
				if (id_edit == IntPtr.Zero)
					id_edit = JNIEnv.GetMethodID (class_ref, "edit", "()Lcom/ta/utdid2/core/persistent/MySharedPreferences$MyEditor;");
				return global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor> (JNIEnv.CallObjectMethod  (Handle, id_edit), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_getBoolean_Ljava_lang_String_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='TransactionXMLFile.MySharedPreferencesImpl']/method[@name='getBoolean' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
			[Register ("getBoolean", "(Ljava/lang/String;Z)Z", "")]
			public bool GetBoolean (string p0, bool p1)
			{
				if (id_getBoolean_Ljava_lang_String_Z == IntPtr.Zero)
					id_getBoolean_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "getBoolean", "(Ljava/lang/String;Z)Z");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_getBoolean_Ljava_lang_String_Z, new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_getFloat_Ljava_lang_String_F;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='TransactionXMLFile.MySharedPreferencesImpl']/method[@name='getFloat' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float']]"
			[Register ("getFloat", "(Ljava/lang/String;F)F", "")]
			public float GetFloat (string p0, float p1)
			{
				if (id_getFloat_Ljava_lang_String_F == IntPtr.Zero)
					id_getFloat_Ljava_lang_String_F = JNIEnv.GetMethodID (class_ref, "getFloat", "(Ljava/lang/String;F)F");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				float __ret = JNIEnv.CallFloatMethod  (Handle, id_getFloat_Ljava_lang_String_F, new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_getInt_Ljava_lang_String_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='TransactionXMLFile.MySharedPreferencesImpl']/method[@name='getInt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
			[Register ("getInt", "(Ljava/lang/String;I)I", "")]
			public int GetInt (string p0, int p1)
			{
				if (id_getInt_Ljava_lang_String_I == IntPtr.Zero)
					id_getInt_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "getInt", "(Ljava/lang/String;I)I");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				int __ret = JNIEnv.CallIntMethod  (Handle, id_getInt_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_getLong_Ljava_lang_String_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='TransactionXMLFile.MySharedPreferencesImpl']/method[@name='getLong' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
			[Register ("getLong", "(Ljava/lang/String;J)J", "")]
			public long GetLong (string p0, long p1)
			{
				if (id_getLong_Ljava_lang_String_J == IntPtr.Zero)
					id_getLong_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "getLong", "(Ljava/lang/String;J)J");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				long __ret = JNIEnv.CallLongMethod  (Handle, id_getLong_Ljava_lang_String_J, new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_getString_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='TransactionXMLFile.MySharedPreferencesImpl']/method[@name='getString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("getString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
			public string GetString (string p0, string p1)
			{
				if (id_getString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_getString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getString_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				return __ret;
			}

			static IntPtr id_registerOnSharedPreferenceChangeListener_Lcom_ta_utdid2_core_persistent_MySharedPreferences_OnSharedPreferenceChangeListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='TransactionXMLFile.MySharedPreferencesImpl']/method[@name='registerOnSharedPreferenceChangeListener' and count(parameter)=1 and parameter[1][@type='com.ta.utdid2.core.persistent.MySharedPreferences.OnSharedPreferenceChangeListener']]"
			[Register ("registerOnSharedPreferenceChangeListener", "(Lcom/ta/utdid2/core/persistent/MySharedPreferences$OnSharedPreferenceChangeListener;)V", "")]
			public void RegisterOnSharedPreferenceChangeListener (global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesOnSharedPreferenceChangeListener p0)
			{
				if (id_registerOnSharedPreferenceChangeListener_Lcom_ta_utdid2_core_persistent_MySharedPreferences_OnSharedPreferenceChangeListener_ == IntPtr.Zero)
					id_registerOnSharedPreferenceChangeListener_Lcom_ta_utdid2_core_persistent_MySharedPreferences_OnSharedPreferenceChangeListener_ = JNIEnv.GetMethodID (class_ref, "registerOnSharedPreferenceChangeListener", "(Lcom/ta/utdid2/core/persistent/MySharedPreferences$OnSharedPreferenceChangeListener;)V");
				JNIEnv.CallVoidMethod  (Handle, id_registerOnSharedPreferenceChangeListener_Lcom_ta_utdid2_core_persistent_MySharedPreferences_OnSharedPreferenceChangeListener_, new JValue (p0));
			}

			static IntPtr id_unregisterOnSharedPreferenceChangeListener_Lcom_ta_utdid2_core_persistent_MySharedPreferences_OnSharedPreferenceChangeListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='TransactionXMLFile.MySharedPreferencesImpl']/method[@name='unregisterOnSharedPreferenceChangeListener' and count(parameter)=1 and parameter[1][@type='com.ta.utdid2.core.persistent.MySharedPreferences.OnSharedPreferenceChangeListener']]"
			[Register ("unregisterOnSharedPreferenceChangeListener", "(Lcom/ta/utdid2/core/persistent/MySharedPreferences$OnSharedPreferenceChangeListener;)V", "")]
			public void UnregisterOnSharedPreferenceChangeListener (global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesOnSharedPreferenceChangeListener p0)
			{
				if (id_unregisterOnSharedPreferenceChangeListener_Lcom_ta_utdid2_core_persistent_MySharedPreferences_OnSharedPreferenceChangeListener_ == IntPtr.Zero)
					id_unregisterOnSharedPreferenceChangeListener_Lcom_ta_utdid2_core_persistent_MySharedPreferences_OnSharedPreferenceChangeListener_ = JNIEnv.GetMethodID (class_ref, "unregisterOnSharedPreferenceChangeListener", "(Lcom/ta/utdid2/core/persistent/MySharedPreferences$OnSharedPreferenceChangeListener;)V");
				JNIEnv.CallVoidMethod  (Handle, id_unregisterOnSharedPreferenceChangeListener_Lcom_ta_utdid2_core_persistent_MySharedPreferences_OnSharedPreferenceChangeListener_, new JValue (p0));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ta/utdid2/core/persistent/TransactionXMLFile", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TransactionXMLFile); }
		}

		protected TransactionXMLFile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='TransactionXMLFile']/constructor[@name='TransactionXMLFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public TransactionXMLFile (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (TransactionXMLFile)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_getMySharedPreferences_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetGetMySharedPreferences_Ljava_lang_String_IHandler ()
		{
			if (cb_getMySharedPreferences_Ljava_lang_String_I == null)
				cb_getMySharedPreferences_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_GetMySharedPreferences_Ljava_lang_String_I);
			return cb_getMySharedPreferences_Ljava_lang_String_I;
		}

		static IntPtr n_GetMySharedPreferences_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.TA.Utdid2.Core.Persistent.TransactionXMLFile __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.TransactionXMLFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMySharedPreferences (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMySharedPreferences_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='TransactionXMLFile']/method[@name='getMySharedPreferences' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getMySharedPreferences", "(Ljava/lang/String;I)Lcom/ta/utdid2/core/persistent/MySharedPreferences;", "GetGetMySharedPreferences_Ljava_lang_String_IHandler")]
		public virtual global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferences GetMySharedPreferences (string p0, int p1)
		{
			if (id_getMySharedPreferences_Ljava_lang_String_I == IntPtr.Zero)
				id_getMySharedPreferences_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "getMySharedPreferences", "(Ljava/lang/String;I)Lcom/ta/utdid2/core/persistent/MySharedPreferences;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferences __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferences> (JNIEnv.CallObjectMethod  (Handle, id_getMySharedPreferences_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferences> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMySharedPreferences", "(Ljava/lang/String;I)Lcom/ta/utdid2/core/persistent/MySharedPreferences;"), new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
