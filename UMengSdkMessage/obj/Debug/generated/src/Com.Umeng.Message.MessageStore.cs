using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageStore']"
	[global::Android.Runtime.Register ("com/umeng/message/MessageStore", DoNotGenerateAcw=true)]
	public partial class MessageStore : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageStore']/field[@name='ActionType']"
		[Register ("ActionType")]
		public const string ActionType = (string) "ActionType";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageStore']/field[@name='ArrivalTime']"
		[Register ("ArrivalTime")]
		public const string ArrivalTime = (string) "ArrivalTime";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageStore']/field[@name='Id']"
		[Register ("Id")]
		public const string Id = (string) "_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageStore']/field[@name='Json']"
		[Register ("Json")]
		public const string Json = (string) "Json";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageStore']/field[@name='MsgId']"
		[Register ("MsgId")]
		public const string MsgId = (string) "MsdId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageStore']/field[@name='SdkVersion']"
		[Register ("SdkVersion")]
		public const string SdkVersion = (string) "SdkVersion";

		static IntPtr instance_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageStore']/field[@name='instance']"
		[Register ("instance")]
		public static global::Com.Umeng.Message.MessageStore Instance {
			get {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lcom/umeng/message/MessageStore;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, instance_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageStore> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lcom/umeng/message/MessageStore;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, instance_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/MessageStore", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessageStore); }
		}

		protected MessageStore (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageStore']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/umeng/message/MessageStore;", "")]
		public static global::Com.Umeng.Message.MessageStore GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lcom/umeng/message/MessageStore;");
			global::Com.Umeng.Message.MessageStore __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageStore> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
