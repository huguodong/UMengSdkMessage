using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Protobuf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.protobuf']/class[@name='ExtensionRegistryLite']"
	[global::Android.Runtime.Register ("com/google/protobuf/ExtensionRegistryLite", DoNotGenerateAcw=true)]
	public partial class ExtensionRegistryLite : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/protobuf/ExtensionRegistryLite", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ExtensionRegistryLite); }
		}

		protected ExtensionRegistryLite (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isEagerlyParseMessageSets;
		static IntPtr id_setEagerlyParseMessageSets_Z;
		public static bool EagerlyParseMessageSets {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='ExtensionRegistryLite']/method[@name='isEagerlyParseMessageSets' and count(parameter)=0]"
			[Register ("isEagerlyParseMessageSets", "()Z", "GetIsEagerlyParseMessageSetsHandler")]
			get {
				if (id_isEagerlyParseMessageSets == IntPtr.Zero)
					id_isEagerlyParseMessageSets = JNIEnv.GetStaticMethodID (class_ref, "isEagerlyParseMessageSets", "()Z");
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isEagerlyParseMessageSets);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='ExtensionRegistryLite']/method[@name='setEagerlyParseMessageSets' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setEagerlyParseMessageSets", "(Z)V", "GetSetEagerlyParseMessageSets_ZHandler")]
			set {
				if (id_setEagerlyParseMessageSets_Z == IntPtr.Zero)
					id_setEagerlyParseMessageSets_Z = JNIEnv.GetStaticMethodID (class_ref, "setEagerlyParseMessageSets", "(Z)V");
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setEagerlyParseMessageSets_Z, new JValue (value));
			}
		}

		static IntPtr id_getEmptyRegistry;
		public static global::Com.Google.Protobuf.ExtensionRegistryLite EmptyRegistry {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='ExtensionRegistryLite']/method[@name='getEmptyRegistry' and count(parameter)=0]"
			[Register ("getEmptyRegistry", "()Lcom/google/protobuf/ExtensionRegistryLite;", "GetGetEmptyRegistryHandler")]
			get {
				if (id_getEmptyRegistry == IntPtr.Zero)
					id_getEmptyRegistry = JNIEnv.GetStaticMethodID (class_ref, "getEmptyRegistry", "()Lcom/google/protobuf/ExtensionRegistryLite;");
				return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ExtensionRegistryLite> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getEmptyRegistry), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getUnmodifiable;
#pragma warning disable 0169
		static Delegate GetGetUnmodifiableHandler ()
		{
			if (cb_getUnmodifiable == null)
				cb_getUnmodifiable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUnmodifiable);
			return cb_getUnmodifiable;
		}

		static IntPtr n_GetUnmodifiable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Protobuf.ExtensionRegistryLite __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ExtensionRegistryLite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Unmodifiable);
		}
#pragma warning restore 0169

		static IntPtr id_getUnmodifiable;
		public virtual global::Com.Google.Protobuf.ExtensionRegistryLite Unmodifiable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='ExtensionRegistryLite']/method[@name='getUnmodifiable' and count(parameter)=0]"
			[Register ("getUnmodifiable", "()Lcom/google/protobuf/ExtensionRegistryLite;", "GetGetUnmodifiableHandler")]
			get {
				if (id_getUnmodifiable == IntPtr.Zero)
					id_getUnmodifiable = JNIEnv.GetMethodID (class_ref, "getUnmodifiable", "()Lcom/google/protobuf/ExtensionRegistryLite;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ExtensionRegistryLite> (JNIEnv.CallObjectMethod  (Handle, id_getUnmodifiable), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ExtensionRegistryLite> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUnmodifiable", "()Lcom/google/protobuf/ExtensionRegistryLite;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_add_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='ExtensionRegistryLite']/method[@name='add' and count(parameter)=1 and parameter[1][@type='com.google.protobuf.GeneratedMessageLite.GeneratedExtension']]"
		[Register ("add", "(Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;)V", "")]
		public void Add (global::Com.Google.Protobuf.GeneratedMessageLite.GeneratedExtension p0)
		{
			if (id_add_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_ == IntPtr.Zero)
				id_add_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_ = JNIEnv.GetMethodID (class_ref, "add", "(Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;)V");
			JNIEnv.CallVoidMethod  (Handle, id_add_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_, new JValue (p0));
		}

		static Delegate cb_findLiteExtensionByNumber_Lcom_google_protobuf_MessageLite_I;
#pragma warning disable 0169
		static Delegate GetFindLiteExtensionByNumber_Lcom_google_protobuf_MessageLite_IHandler ()
		{
			if (cb_findLiteExtensionByNumber_Lcom_google_protobuf_MessageLite_I == null)
				cb_findLiteExtensionByNumber_Lcom_google_protobuf_MessageLite_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_FindLiteExtensionByNumber_Lcom_google_protobuf_MessageLite_I);
			return cb_findLiteExtensionByNumber_Lcom_google_protobuf_MessageLite_I;
		}

		static IntPtr n_FindLiteExtensionByNumber_Lcom_google_protobuf_MessageLite_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Google.Protobuf.ExtensionRegistryLite __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ExtensionRegistryLite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FindLiteExtensionByNumber (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_findLiteExtensionByNumber_Lcom_google_protobuf_MessageLite_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='ExtensionRegistryLite']/method[@name='findLiteExtensionByNumber' and count(parameter)=2 and parameter[1][@type='com.google.protobuf.MessageLite'] and parameter[2][@type='int']]"
		[Register ("findLiteExtensionByNumber", "(Lcom/google/protobuf/MessageLite;I)Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;", "GetFindLiteExtensionByNumber_Lcom_google_protobuf_MessageLite_IHandler")]
		public virtual global::Com.Google.Protobuf.GeneratedMessageLite.GeneratedExtension FindLiteExtensionByNumber (global::Java.Lang.Object p0, int p1)
		{
			if (id_findLiteExtensionByNumber_Lcom_google_protobuf_MessageLite_I == IntPtr.Zero)
				id_findLiteExtensionByNumber_Lcom_google_protobuf_MessageLite_I = JNIEnv.GetMethodID (class_ref, "findLiteExtensionByNumber", "(Lcom/google/protobuf/MessageLite;I)Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);

			global::Com.Google.Protobuf.GeneratedMessageLite.GeneratedExtension __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.GeneratedMessageLite.GeneratedExtension> (JNIEnv.CallObjectMethod  (Handle, id_findLiteExtensionByNumber_Lcom_google_protobuf_MessageLite_I, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.GeneratedMessageLite.GeneratedExtension> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "findLiteExtensionByNumber", "(Lcom/google/protobuf/MessageLite;I)Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;"), new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_newInstance;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='ExtensionRegistryLite']/method[@name='newInstance' and count(parameter)=0]"
		[Register ("newInstance", "()Lcom/google/protobuf/ExtensionRegistryLite;", "")]
		public static global::Com.Google.Protobuf.ExtensionRegistryLite NewInstance ()
		{
			if (id_newInstance == IntPtr.Zero)
				id_newInstance = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "()Lcom/google/protobuf/ExtensionRegistryLite;");
			return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ExtensionRegistryLite> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance), JniHandleOwnership.TransferLocalRef);
		}

	}
}
