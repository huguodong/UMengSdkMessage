using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message.Tag {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message.tag']/class[@name='TagManager']"
	[global::Android.Runtime.Register ("com/umeng/message/tag/TagManager", DoNotGenerateAcw=true)]
	public partial class TagManager : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message.tag']/class[@name='TagManager.Result']"
		[global::Android.Runtime.Register ("com/umeng/message/tag/TagManager$Result", DoNotGenerateAcw=true)]
		public partial class Result : global::Java.Lang.Object {


			static IntPtr errors_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.tag']/class[@name='TagManager.Result']/field[@name='errors']"
			[Register ("errors")]
			public string Errors {
				get {
					if (errors_jfieldId == IntPtr.Zero)
						errors_jfieldId = JNIEnv.GetFieldID (class_ref, "errors", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, errors_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (errors_jfieldId == IntPtr.Zero)
						errors_jfieldId = JNIEnv.GetFieldID (class_ref, "errors", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					JNIEnv.SetField (Handle, errors_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr jsonString_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.tag']/class[@name='TagManager.Result']/field[@name='jsonString']"
			[Register ("jsonString")]
			public string JsonString {
				get {
					if (jsonString_jfieldId == IntPtr.Zero)
						jsonString_jfieldId = JNIEnv.GetFieldID (class_ref, "jsonString", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, jsonString_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (jsonString_jfieldId == IntPtr.Zero)
						jsonString_jfieldId = JNIEnv.GetFieldID (class_ref, "jsonString", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					JNIEnv.SetField (Handle, jsonString_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr remain_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.tag']/class[@name='TagManager.Result']/field[@name='remain']"
			[Register ("remain")]
			public int Remain {
				get {
					if (remain_jfieldId == IntPtr.Zero)
						remain_jfieldId = JNIEnv.GetFieldID (class_ref, "remain", "I");
					return JNIEnv.GetIntField (Handle, remain_jfieldId);
				}
				set {
					if (remain_jfieldId == IntPtr.Zero)
						remain_jfieldId = JNIEnv.GetFieldID (class_ref, "remain", "I");
					JNIEnv.SetField (Handle, remain_jfieldId, value);
				}
			}

			static IntPtr status_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.tag']/class[@name='TagManager.Result']/field[@name='status']"
			[Register ("status")]
			public string Status {
				get {
					if (status_jfieldId == IntPtr.Zero)
						status_jfieldId = JNIEnv.GetFieldID (class_ref, "status", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, status_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (status_jfieldId == IntPtr.Zero)
						status_jfieldId = JNIEnv.GetFieldID (class_ref, "status", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					JNIEnv.SetField (Handle, status_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/umeng/message/tag/TagManager$Result", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Result); }
			}

			protected Result (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_json_JSONObject_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.message.tag']/class[@name='TagManager.Result']/constructor[@name='TagManager.Result' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
			public Result (global::Org.Json.JSONObject p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Result)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/json/JSONObject;)V", new JValue (p0)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/json/JSONObject;)V", new JValue (p0));
					return;
				}

				if (id_ctor_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_ctor_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/json/JSONObject;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_json_JSONObject_, new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_json_JSONObject_, new JValue (p0));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/tag/TagManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TagManager); }
		}

		protected TagManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_add_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAdd_arrayLjava_lang_String_Handler ()
		{
			if (cb_add_arrayLjava_lang_String_ == null)
				cb_add_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Add_arrayLjava_lang_String_);
			return cb_add_arrayLjava_lang_String_;
		}

		static IntPtr n_Add_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.Tag.TagManager __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Tag.TagManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Add (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_add_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.tag']/class[@name='TagManager']/method[@name='add' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("add", "([Ljava/lang/String;)Lcom/umeng/message/tag/TagManager$Result;", "GetAdd_arrayLjava_lang_String_Handler")]
		public virtual global::Com.Umeng.Message.Tag.TagManager.Result Add (params  string[] p0)
		{
			if (id_add_arrayLjava_lang_String_ == IntPtr.Zero)
				id_add_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "add", "([Ljava/lang/String;)Lcom/umeng/message/tag/TagManager$Result;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			global::Com.Umeng.Message.Tag.TagManager.Result __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Tag.TagManager.Result> (JNIEnv.CallObjectMethod  (Handle, id_add_arrayLjava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Tag.TagManager.Result> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "([Ljava/lang/String;)Lcom/umeng/message/tag/TagManager$Result;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_delete_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDelete_arrayLjava_lang_String_Handler ()
		{
			if (cb_delete_arrayLjava_lang_String_ == null)
				cb_delete_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Delete_arrayLjava_lang_String_);
			return cb_delete_arrayLjava_lang_String_;
		}

		static IntPtr n_Delete_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.Tag.TagManager __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Tag.TagManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Delete (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_delete_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.tag']/class[@name='TagManager']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("delete", "([Ljava/lang/String;)Lcom/umeng/message/tag/TagManager$Result;", "GetDelete_arrayLjava_lang_String_Handler")]
		public virtual global::Com.Umeng.Message.Tag.TagManager.Result Delete (params  string[] p0)
		{
			if (id_delete_arrayLjava_lang_String_ == IntPtr.Zero)
				id_delete_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "delete", "([Ljava/lang/String;)Lcom/umeng/message/tag/TagManager$Result;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			global::Com.Umeng.Message.Tag.TagManager.Result __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Tag.TagManager.Result> (JNIEnv.CallObjectMethod  (Handle, id_delete_arrayLjava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Tag.TagManager.Result> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "delete", "([Ljava/lang/String;)Lcom/umeng/message/tag/TagManager$Result;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.tag']/class[@name='TagManager']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/umeng/message/tag/TagManager;", "")]
		public static global::Com.Umeng.Message.Tag.TagManager GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lcom/umeng/message/tag/TagManager;");
			global::Com.Umeng.Message.Tag.TagManager __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Tag.TagManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_list;
#pragma warning disable 0169
		static Delegate GetListHandler ()
		{
			if (cb_list == null)
				cb_list = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_List);
			return cb_list;
		}

		static IntPtr n_List (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.Tag.TagManager __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Tag.TagManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.List ());
		}
#pragma warning restore 0169

		static IntPtr id_list;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.tag']/class[@name='TagManager']/method[@name='list' and count(parameter)=0]"
		[Register ("list", "()Ljava/util/List;", "GetListHandler")]
		public virtual global::System.Collections.Generic.IList<string> List ()
		{
			if (id_list == IntPtr.Zero)
				id_list = JNIEnv.GetMethodID (class_ref, "list", "()Ljava/util/List;");

			if (GetType () == ThresholdType)
				return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_list), JniHandleOwnership.TransferLocalRef);
			else
				return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "list", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static IntPtr n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.Tag.TagManager __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Tag.TagManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Reset ());
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.tag']/class[@name='TagManager']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()Lcom/umeng/message/tag/TagManager$Result;", "GetResetHandler")]
		public virtual global::Com.Umeng.Message.Tag.TagManager.Result Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()Lcom/umeng/message/tag/TagManager$Result;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Tag.TagManager.Result> (JNIEnv.CallObjectMethod  (Handle, id_reset), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Tag.TagManager.Result> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "()Lcom/umeng/message/tag/TagManager$Result;")), JniHandleOwnership.TransferLocalRef);
		}

	}
}
