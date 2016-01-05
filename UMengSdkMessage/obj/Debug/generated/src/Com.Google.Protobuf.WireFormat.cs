using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Protobuf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat']"
	[global::Android.Runtime.Register ("com/google/protobuf/WireFormat", DoNotGenerateAcw=true)]
	public sealed partial class WireFormat : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat']/field[@name='WIRETYPE_END_GROUP']"
		[Register ("WIRETYPE_END_GROUP")]
		public const int WiretypeEndGroup = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat']/field[@name='WIRETYPE_FIXED32']"
		[Register ("WIRETYPE_FIXED32")]
		public const int WiretypeFixed32 = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat']/field[@name='WIRETYPE_FIXED64']"
		[Register ("WIRETYPE_FIXED64")]
		public const int WiretypeFixed64 = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat']/field[@name='WIRETYPE_LENGTH_DELIMITED']"
		[Register ("WIRETYPE_LENGTH_DELIMITED")]
		public const int WiretypeLengthDelimited = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat']/field[@name='WIRETYPE_START_GROUP']"
		[Register ("WIRETYPE_START_GROUP")]
		public const int WiretypeStartGroup = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat']/field[@name='WIRETYPE_VARINT']"
		[Register ("WIRETYPE_VARINT")]
		public const int WiretypeVarint = (int) 0;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat.FieldType']"
		[global::Android.Runtime.Register ("com/google/protobuf/WireFormat$FieldType", DoNotGenerateAcw=true)]
		public partial class FieldType : global::Java.Lang.Enum {


			static IntPtr BOOL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat.FieldType']/field[@name='BOOL']"
			[Register ("BOOL")]
			public static global::Com.Google.Protobuf.WireFormat.FieldType Bool {
				get {
					if (BOOL_jfieldId == IntPtr.Zero)
						BOOL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOOL", "Lcom/google/protobuf/WireFormat$FieldType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BOOL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.WireFormat.FieldType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (BOOL_jfieldId == IntPtr.Zero)
						BOOL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOOL", "Lcom/google/protobuf/WireFormat$FieldType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, BOOL_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr BYTES_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat.FieldType']/field[@name='BYTES']"
			[Register ("BYTES")]
			public static global::Com.Google.Protobuf.WireFormat.FieldType Bytes {
				get {
					if (BYTES_jfieldId == IntPtr.Zero)
						BYTES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BYTES", "Lcom/google/protobuf/WireFormat$FieldType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BYTES_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.WireFormat.FieldType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (BYTES_jfieldId == IntPtr.Zero)
						BYTES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BYTES", "Lcom/google/protobuf/WireFormat$FieldType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, BYTES_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr DOUBLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat.FieldType']/field[@name='DOUBLE']"
			[Register ("DOUBLE")]
			public static global::Com.Google.Protobuf.WireFormat.FieldType Double {
				get {
					if (DOUBLE_jfieldId == IntPtr.Zero)
						DOUBLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOUBLE", "Lcom/google/protobuf/WireFormat$FieldType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DOUBLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.WireFormat.FieldType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DOUBLE_jfieldId == IntPtr.Zero)
						DOUBLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOUBLE", "Lcom/google/protobuf/WireFormat$FieldType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DOUBLE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ENUM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat.FieldType']/field[@name='ENUM']"
			[Register ("ENUM")]
			public static global::Com.Google.Protobuf.WireFormat.FieldType Enum {
				get {
					if (ENUM_jfieldId == IntPtr.Zero)
						ENUM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ENUM", "Lcom/google/protobuf/WireFormat$FieldType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ENUM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.WireFormat.FieldType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ENUM_jfieldId == IntPtr.Zero)
						ENUM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ENUM", "Lcom/google/protobuf/WireFormat$FieldType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ENUM_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr FIXED32_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat.FieldType']/field[@name='FIXED32']"
			[Register ("FIXED32")]
			public static global::Com.Google.Protobuf.WireFormat.FieldType Fixed32 {
				get {
					if (FIXED32_jfieldId == IntPtr.Zero)
						FIXED32_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FIXED32", "Lcom/google/protobuf/WireFormat$FieldType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FIXED32_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.WireFormat.FieldType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (FIXED32_jfieldId == IntPtr.Zero)
						FIXED32_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FIXED32", "Lcom/google/protobuf/WireFormat$FieldType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, FIXED32_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr FIXED64_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat.FieldType']/field[@name='FIXED64']"
			[Register ("FIXED64")]
			public static global::Com.Google.Protobuf.WireFormat.FieldType Fixed64 {
				get {
					if (FIXED64_jfieldId == IntPtr.Zero)
						FIXED64_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FIXED64", "Lcom/google/protobuf/WireFormat$FieldType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FIXED64_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.WireFormat.FieldType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (FIXED64_jfieldId == IntPtr.Zero)
						FIXED64_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FIXED64", "Lcom/google/protobuf/WireFormat$FieldType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, FIXED64_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr FLOAT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat.FieldType']/field[@name='FLOAT']"
			[Register ("FLOAT")]
			public static global::Com.Google.Protobuf.WireFormat.FieldType Float {
				get {
					if (FLOAT_jfieldId == IntPtr.Zero)
						FLOAT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FLOAT", "Lcom/google/protobuf/WireFormat$FieldType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FLOAT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.WireFormat.FieldType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (FLOAT_jfieldId == IntPtr.Zero)
						FLOAT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FLOAT", "Lcom/google/protobuf/WireFormat$FieldType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, FLOAT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr GROUP_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat.FieldType']/field[@name='GROUP']"
			[Register ("GROUP")]
			public static global::Com.Google.Protobuf.WireFormat.FieldType Group {
				get {
					if (GROUP_jfieldId == IntPtr.Zero)
						GROUP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GROUP", "Lcom/google/protobuf/WireFormat$FieldType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GROUP_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.WireFormat.FieldType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (GROUP_jfieldId == IntPtr.Zero)
						GROUP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GROUP", "Lcom/google/protobuf/WireFormat$FieldType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, GROUP_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr INT32_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat.FieldType']/field[@name='INT32']"
			[Register ("INT32")]
			public static global::Com.Google.Protobuf.WireFormat.FieldType Int32 {
				get {
					if (INT32_jfieldId == IntPtr.Zero)
						INT32_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INT32", "Lcom/google/protobuf/WireFormat$FieldType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INT32_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.WireFormat.FieldType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (INT32_jfieldId == IntPtr.Zero)
						INT32_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INT32", "Lcom/google/protobuf/WireFormat$FieldType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, INT32_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr INT64_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat.FieldType']/field[@name='INT64']"
			[Register ("INT64")]
			public static global::Com.Google.Protobuf.WireFormat.FieldType Int64 {
				get {
					if (INT64_jfieldId == IntPtr.Zero)
						INT64_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INT64", "Lcom/google/protobuf/WireFormat$FieldType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INT64_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.WireFormat.FieldType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (INT64_jfieldId == IntPtr.Zero)
						INT64_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INT64", "Lcom/google/protobuf/WireFormat$FieldType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, INT64_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr MESSAGE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat.FieldType']/field[@name='MESSAGE']"
			[Register ("MESSAGE")]
			public static global::Com.Google.Protobuf.WireFormat.FieldType Message {
				get {
					if (MESSAGE_jfieldId == IntPtr.Zero)
						MESSAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE", "Lcom/google/protobuf/WireFormat$FieldType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MESSAGE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.WireFormat.FieldType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (MESSAGE_jfieldId == IntPtr.Zero)
						MESSAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE", "Lcom/google/protobuf/WireFormat$FieldType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, MESSAGE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr SFIXED32_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat.FieldType']/field[@name='SFIXED32']"
			[Register ("SFIXED32")]
			public static global::Com.Google.Protobuf.WireFormat.FieldType Sfixed32 {
				get {
					if (SFIXED32_jfieldId == IntPtr.Zero)
						SFIXED32_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SFIXED32", "Lcom/google/protobuf/WireFormat$FieldType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SFIXED32_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.WireFormat.FieldType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (SFIXED32_jfieldId == IntPtr.Zero)
						SFIXED32_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SFIXED32", "Lcom/google/protobuf/WireFormat$FieldType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, SFIXED32_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr SFIXED64_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat.FieldType']/field[@name='SFIXED64']"
			[Register ("SFIXED64")]
			public static global::Com.Google.Protobuf.WireFormat.FieldType Sfixed64 {
				get {
					if (SFIXED64_jfieldId == IntPtr.Zero)
						SFIXED64_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SFIXED64", "Lcom/google/protobuf/WireFormat$FieldType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SFIXED64_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.WireFormat.FieldType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (SFIXED64_jfieldId == IntPtr.Zero)
						SFIXED64_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SFIXED64", "Lcom/google/protobuf/WireFormat$FieldType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, SFIXED64_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr SINT32_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat.FieldType']/field[@name='SINT32']"
			[Register ("SINT32")]
			public static global::Com.Google.Protobuf.WireFormat.FieldType Sint32 {
				get {
					if (SINT32_jfieldId == IntPtr.Zero)
						SINT32_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SINT32", "Lcom/google/protobuf/WireFormat$FieldType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SINT32_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.WireFormat.FieldType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (SINT32_jfieldId == IntPtr.Zero)
						SINT32_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SINT32", "Lcom/google/protobuf/WireFormat$FieldType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, SINT32_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr SINT64_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat.FieldType']/field[@name='SINT64']"
			[Register ("SINT64")]
			public static global::Com.Google.Protobuf.WireFormat.FieldType Sint64 {
				get {
					if (SINT64_jfieldId == IntPtr.Zero)
						SINT64_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SINT64", "Lcom/google/protobuf/WireFormat$FieldType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SINT64_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.WireFormat.FieldType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (SINT64_jfieldId == IntPtr.Zero)
						SINT64_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SINT64", "Lcom/google/protobuf/WireFormat$FieldType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, SINT64_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr STRING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat.FieldType']/field[@name='STRING']"
			[Register ("STRING")]
			public static global::Com.Google.Protobuf.WireFormat.FieldType String {
				get {
					if (STRING_jfieldId == IntPtr.Zero)
						STRING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STRING", "Lcom/google/protobuf/WireFormat$FieldType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STRING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.WireFormat.FieldType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (STRING_jfieldId == IntPtr.Zero)
						STRING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STRING", "Lcom/google/protobuf/WireFormat$FieldType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, STRING_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr UINT32_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat.FieldType']/field[@name='UINT32']"
			[Register ("UINT32")]
			public static global::Com.Google.Protobuf.WireFormat.FieldType Uint32 {
				get {
					if (UINT32_jfieldId == IntPtr.Zero)
						UINT32_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UINT32", "Lcom/google/protobuf/WireFormat$FieldType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UINT32_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.WireFormat.FieldType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (UINT32_jfieldId == IntPtr.Zero)
						UINT32_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UINT32", "Lcom/google/protobuf/WireFormat$FieldType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, UINT32_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr UINT64_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat.FieldType']/field[@name='UINT64']"
			[Register ("UINT64")]
			public static global::Com.Google.Protobuf.WireFormat.FieldType Uint64 {
				get {
					if (UINT64_jfieldId == IntPtr.Zero)
						UINT64_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UINT64", "Lcom/google/protobuf/WireFormat$FieldType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UINT64_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.WireFormat.FieldType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (UINT64_jfieldId == IntPtr.Zero)
						UINT64_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UINT64", "Lcom/google/protobuf/WireFormat$FieldType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, UINT64_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/protobuf/WireFormat$FieldType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FieldType); }
			}

			protected FieldType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_isPackable;
#pragma warning disable 0169
			static Delegate GetIsPackableHandler ()
			{
				if (cb_isPackable == null)
					cb_isPackable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPackable);
				return cb_isPackable;
			}

			static bool n_IsPackable (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Protobuf.WireFormat.FieldType __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.WireFormat.FieldType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsPackable;
			}
#pragma warning restore 0169

			static IntPtr id_isPackable;
			public virtual bool IsPackable {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat.FieldType']/method[@name='isPackable' and count(parameter)=0]"
				[Register ("isPackable", "()Z", "GetIsPackableHandler")]
				get {
					if (id_isPackable == IntPtr.Zero)
						id_isPackable = JNIEnv.GetMethodID (class_ref, "isPackable", "()Z");

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isPackable);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isPackable", "()Z"));
				}
			}

			static Delegate cb_getJavaType;
#pragma warning disable 0169
			static Delegate GetGetJavaTypeHandler ()
			{
				if (cb_getJavaType == null)
					cb_getJavaType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetJavaType);
				return cb_getJavaType;
			}

			static IntPtr n_GetJavaType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Protobuf.WireFormat.FieldType __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.WireFormat.FieldType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.JavaType);
			}
#pragma warning restore 0169

			static IntPtr id_getJavaType;
			public virtual global::Com.Google.Protobuf.WireFormat.JavaType JavaType {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat.FieldType']/method[@name='getJavaType' and count(parameter)=0]"
				[Register ("getJavaType", "()Lcom/google/protobuf/WireFormat$JavaType;", "GetGetJavaTypeHandler")]
				get {
					if (id_getJavaType == IntPtr.Zero)
						id_getJavaType = JNIEnv.GetMethodID (class_ref, "getJavaType", "()Lcom/google/protobuf/WireFormat$JavaType;");

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.WireFormat.JavaType> (JNIEnv.CallObjectMethod  (Handle, id_getJavaType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.WireFormat.JavaType> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getJavaType", "()Lcom/google/protobuf/WireFormat$JavaType;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getWireType;
#pragma warning disable 0169
			static Delegate GetGetWireTypeHandler ()
			{
				if (cb_getWireType == null)
					cb_getWireType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWireType);
				return cb_getWireType;
			}

			static int n_GetWireType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Protobuf.WireFormat.FieldType __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.WireFormat.FieldType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.WireType;
			}
#pragma warning restore 0169

			static IntPtr id_getWireType;
			public virtual int WireType {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat.FieldType']/method[@name='getWireType' and count(parameter)=0]"
				[Register ("getWireType", "()I", "GetGetWireTypeHandler")]
				get {
					if (id_getWireType == IntPtr.Zero)
						id_getWireType = JNIEnv.GetMethodID (class_ref, "getWireType", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getWireType);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWireType", "()I"));
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat.FieldType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/protobuf/WireFormat$FieldType;", "")]
			public static global::Com.Google.Protobuf.WireFormat.FieldType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/google/protobuf/WireFormat$FieldType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Google.Protobuf.WireFormat.FieldType __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.WireFormat.FieldType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat.FieldType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/google/protobuf/WireFormat$FieldType;", "")]
			public static global::Com.Google.Protobuf.WireFormat.FieldType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/google/protobuf/WireFormat$FieldType;");
				return (global::Com.Google.Protobuf.WireFormat.FieldType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Protobuf.WireFormat.FieldType));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat.JavaType']"
		[global::Android.Runtime.Register ("com/google/protobuf/WireFormat$JavaType", DoNotGenerateAcw=true)]
		public sealed partial class JavaType : global::Java.Lang.Enum {


			static IntPtr BOOLEAN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat.JavaType']/field[@name='BOOLEAN']"
			[Register ("BOOLEAN")]
			public static global::Com.Google.Protobuf.WireFormat.JavaType Boolean {
				get {
					if (BOOLEAN_jfieldId == IntPtr.Zero)
						BOOLEAN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOOLEAN", "Lcom/google/protobuf/WireFormat$JavaType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BOOLEAN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.WireFormat.JavaType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (BOOLEAN_jfieldId == IntPtr.Zero)
						BOOLEAN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOOLEAN", "Lcom/google/protobuf/WireFormat$JavaType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, BOOLEAN_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr BYTE_STRING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat.JavaType']/field[@name='BYTE_STRING']"
			[Register ("BYTE_STRING")]
			public static global::Com.Google.Protobuf.WireFormat.JavaType ByteString {
				get {
					if (BYTE_STRING_jfieldId == IntPtr.Zero)
						BYTE_STRING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BYTE_STRING", "Lcom/google/protobuf/WireFormat$JavaType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BYTE_STRING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.WireFormat.JavaType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (BYTE_STRING_jfieldId == IntPtr.Zero)
						BYTE_STRING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BYTE_STRING", "Lcom/google/protobuf/WireFormat$JavaType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, BYTE_STRING_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr DOUBLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat.JavaType']/field[@name='DOUBLE']"
			[Register ("DOUBLE")]
			public static global::Com.Google.Protobuf.WireFormat.JavaType Double {
				get {
					if (DOUBLE_jfieldId == IntPtr.Zero)
						DOUBLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOUBLE", "Lcom/google/protobuf/WireFormat$JavaType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DOUBLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.WireFormat.JavaType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DOUBLE_jfieldId == IntPtr.Zero)
						DOUBLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOUBLE", "Lcom/google/protobuf/WireFormat$JavaType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DOUBLE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ENUM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat.JavaType']/field[@name='ENUM']"
			[Register ("ENUM")]
			public static global::Com.Google.Protobuf.WireFormat.JavaType Enum {
				get {
					if (ENUM_jfieldId == IntPtr.Zero)
						ENUM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ENUM", "Lcom/google/protobuf/WireFormat$JavaType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ENUM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.WireFormat.JavaType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ENUM_jfieldId == IntPtr.Zero)
						ENUM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ENUM", "Lcom/google/protobuf/WireFormat$JavaType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ENUM_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr FLOAT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat.JavaType']/field[@name='FLOAT']"
			[Register ("FLOAT")]
			public static global::Com.Google.Protobuf.WireFormat.JavaType Float {
				get {
					if (FLOAT_jfieldId == IntPtr.Zero)
						FLOAT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FLOAT", "Lcom/google/protobuf/WireFormat$JavaType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FLOAT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.WireFormat.JavaType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (FLOAT_jfieldId == IntPtr.Zero)
						FLOAT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FLOAT", "Lcom/google/protobuf/WireFormat$JavaType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, FLOAT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr INT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat.JavaType']/field[@name='INT']"
			[Register ("INT")]
			public static global::Com.Google.Protobuf.WireFormat.JavaType Int {
				get {
					if (INT_jfieldId == IntPtr.Zero)
						INT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INT", "Lcom/google/protobuf/WireFormat$JavaType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.WireFormat.JavaType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (INT_jfieldId == IntPtr.Zero)
						INT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INT", "Lcom/google/protobuf/WireFormat$JavaType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, INT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr LONG_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat.JavaType']/field[@name='LONG']"
			[Register ("LONG")]
			public static global::Com.Google.Protobuf.WireFormat.JavaType Long {
				get {
					if (LONG_jfieldId == IntPtr.Zero)
						LONG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LONG", "Lcom/google/protobuf/WireFormat$JavaType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LONG_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.WireFormat.JavaType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (LONG_jfieldId == IntPtr.Zero)
						LONG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LONG", "Lcom/google/protobuf/WireFormat$JavaType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, LONG_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr MESSAGE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat.JavaType']/field[@name='MESSAGE']"
			[Register ("MESSAGE")]
			public static global::Com.Google.Protobuf.WireFormat.JavaType Message {
				get {
					if (MESSAGE_jfieldId == IntPtr.Zero)
						MESSAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE", "Lcom/google/protobuf/WireFormat$JavaType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MESSAGE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.WireFormat.JavaType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (MESSAGE_jfieldId == IntPtr.Zero)
						MESSAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE", "Lcom/google/protobuf/WireFormat$JavaType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, MESSAGE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr STRING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat.JavaType']/field[@name='STRING']"
			[Register ("STRING")]
			public static global::Com.Google.Protobuf.WireFormat.JavaType String {
				get {
					if (STRING_jfieldId == IntPtr.Zero)
						STRING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STRING", "Lcom/google/protobuf/WireFormat$JavaType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STRING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.WireFormat.JavaType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (STRING_jfieldId == IntPtr.Zero)
						STRING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STRING", "Lcom/google/protobuf/WireFormat$JavaType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, STRING_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/protobuf/WireFormat$JavaType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (JavaType); }
			}

			internal JavaType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat.JavaType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/protobuf/WireFormat$JavaType;", "")]
			public static global::Com.Google.Protobuf.WireFormat.JavaType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/google/protobuf/WireFormat$JavaType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Google.Protobuf.WireFormat.JavaType __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.WireFormat.JavaType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat.JavaType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/google/protobuf/WireFormat$JavaType;", "")]
			public static global::Com.Google.Protobuf.WireFormat.JavaType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/google/protobuf/WireFormat$JavaType;");
				return (global::Com.Google.Protobuf.WireFormat.JavaType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Protobuf.WireFormat.JavaType));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/protobuf/WireFormat", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WireFormat); }
		}

		internal WireFormat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getTagFieldNumber_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='WireFormat']/method[@name='getTagFieldNumber' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getTagFieldNumber", "(I)I", "")]
		public static int GetTagFieldNumber (int p0)
		{
			if (id_getTagFieldNumber_I == IntPtr.Zero)
				id_getTagFieldNumber_I = JNIEnv.GetStaticMethodID (class_ref, "getTagFieldNumber", "(I)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_getTagFieldNumber_I, new JValue (p0));
		}

	}
}
