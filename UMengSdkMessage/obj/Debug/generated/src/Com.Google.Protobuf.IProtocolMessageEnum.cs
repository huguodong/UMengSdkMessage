using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Protobuf {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.protobuf']/interface[@name='ProtocolMessageEnum']"
	[Register ("com/google/protobuf/ProtocolMessageEnum", "", "Com.Google.Protobuf.IProtocolMessageEnumInvoker")]
	public partial interface IProtocolMessageEnum : global::Com.Google.Protobuf.Internal.IEnumLite {

		global::Com.Google.Protobuf.Descriptors.EnumDescriptor DescriptorForType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/interface[@name='ProtocolMessageEnum']/method[@name='getDescriptorForType' and count(parameter)=0]"
			[Register ("getDescriptorForType", "()Lcom/google/protobuf/Descriptors$EnumDescriptor;", "GetGetDescriptorForTypeHandler:Com.Google.Protobuf.IProtocolMessageEnumInvoker, UMengSdkMessage")] get;
		}

		int Number {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/interface[@name='ProtocolMessageEnum']/method[@name='getNumber' and count(parameter)=0]"
			[Register ("getNumber", "()I", "GetGetNumberHandler:Com.Google.Protobuf.IProtocolMessageEnumInvoker, UMengSdkMessage")] get;
		}

		global::Com.Google.Protobuf.Descriptors.EnumValueDescriptor ValueDescriptor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/interface[@name='ProtocolMessageEnum']/method[@name='getValueDescriptor' and count(parameter)=0]"
			[Register ("getValueDescriptor", "()Lcom/google/protobuf/Descriptors$EnumValueDescriptor;", "GetGetValueDescriptorHandler:Com.Google.Protobuf.IProtocolMessageEnumInvoker, UMengSdkMessage")] get;
		}

	}

	[global::Android.Runtime.Register ("com/google/protobuf/ProtocolMessageEnum", DoNotGenerateAcw=true)]
	internal class IProtocolMessageEnumInvoker : global::Java.Lang.Object, IProtocolMessageEnum {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/protobuf/ProtocolMessageEnum");
		IntPtr class_ref;

		public static IProtocolMessageEnum GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IProtocolMessageEnum> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.protobuf.ProtocolMessageEnum"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IProtocolMessageEnumInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IProtocolMessageEnumInvoker); }
		}

		static Delegate cb_getDescriptorForType;
#pragma warning disable 0169
		static Delegate GetGetDescriptorForTypeHandler ()
		{
			if (cb_getDescriptorForType == null)
				cb_getDescriptorForType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDescriptorForType);
			return cb_getDescriptorForType;
		}

		static IntPtr n_GetDescriptorForType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Protobuf.IProtocolMessageEnum __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IProtocolMessageEnum> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DescriptorForType);
		}
#pragma warning restore 0169

		IntPtr id_getDescriptorForType;
		public global::Com.Google.Protobuf.Descriptors.EnumDescriptor DescriptorForType {
			get {
				if (id_getDescriptorForType == IntPtr.Zero)
					id_getDescriptorForType = JNIEnv.GetMethodID (class_ref, "getDescriptorForType", "()Lcom/google/protobuf/Descriptors$EnumDescriptor;");
				return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.EnumDescriptor> (JNIEnv.CallObjectMethod (Handle, id_getDescriptorForType), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getNumber;
#pragma warning disable 0169
		static Delegate GetGetNumberHandler ()
		{
			if (cb_getNumber == null)
				cb_getNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumber);
			return cb_getNumber;
		}

		static int n_GetNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Protobuf.IProtocolMessageEnum __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IProtocolMessageEnum> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Number;
		}
#pragma warning restore 0169

		IntPtr id_getNumber;
		public int Number {
			get {
				if (id_getNumber == IntPtr.Zero)
					id_getNumber = JNIEnv.GetMethodID (class_ref, "getNumber", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getNumber);
			}
		}

		static Delegate cb_getValueDescriptor;
#pragma warning disable 0169
		static Delegate GetGetValueDescriptorHandler ()
		{
			if (cb_getValueDescriptor == null)
				cb_getValueDescriptor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValueDescriptor);
			return cb_getValueDescriptor;
		}

		static IntPtr n_GetValueDescriptor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Protobuf.IProtocolMessageEnum __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IProtocolMessageEnum> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ValueDescriptor);
		}
#pragma warning restore 0169

		IntPtr id_getValueDescriptor;
		public global::Com.Google.Protobuf.Descriptors.EnumValueDescriptor ValueDescriptor {
			get {
				if (id_getValueDescriptor == IntPtr.Zero)
					id_getValueDescriptor = JNIEnv.GetMethodID (class_ref, "getValueDescriptor", "()Lcom/google/protobuf/Descriptors$EnumValueDescriptor;");
				return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Descriptors.EnumValueDescriptor> (JNIEnv.CallObjectMethod (Handle, id_getValueDescriptor), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
