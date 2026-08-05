using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using Cpp2IlInjected;
using Google.Protobuf;
using JetBrains.Annotations;
using RecRoom.Protobuf;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Utils.OverridableFields
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public interface JGWVUYIBRSU
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface WFXRKJIKYCT<a> : JGWVUYIBRSU
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		a Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface CZTXUKWNXJN<a> : WFXRKJIKYCT<a>, JGWVUYIBRSU
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		new bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		new a Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface PGOWMFRSRCA<a> : CZTXUKWNXJN<a>, WFXRKJIKYCT<a>, JGWVUYIBRSU
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class PIIHOCKXAPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x83F01F0", Offset = "0x83EF3F0", VA = "0x1883F01F0")]
		public static float? ODYDHUNSERS(this OverridableFloat a)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableInt : WFXRKJIKYCT<int>, JGWVUYIBRSU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private int value;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xE54D90", Offset = "0xE53F90", VA = "0x180E54D90", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x83F0050", Offset = "0x83EF250", VA = "0x1883F0050", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2E3FA90", Offset = "0x2E3EC90", VA = "0x182E3FA90", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x83EFFD0", Offset = "0x83EF1D0", VA = "0x1883EFFD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct OverridableFloat : WFXRKJIKYCT<float>, JGWVUYIBRSU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private float value;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xE54D90", Offset = "0xE53F90", VA = "0x180E54D90", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x83EFFA0", Offset = "0x83EF1A0", VA = "0x1883EFFA0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public float Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x2BB5BB0", Offset = "0x2BB4DB0", VA = "0x182BB5BB0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x83EFF20", Offset = "0x83EF120", VA = "0x1883EFF20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct OverridableString : WFXRKJIKYCT<string>, JGWVUYIBRSU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		private string value;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xE54D90", Offset = "0xE53F90", VA = "0x180E54D90", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xCCFB50", Offset = "0xCCED50", VA = "0x180CCFB50", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xCCFB50", Offset = "0xCCED50", VA = "0x180CCFB50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x83F0080", Offset = "0x83EF280", VA = "0x1883F0080", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public abstract class DVNCMZHBWFJ<a, b, c> : CZTXUKWNXJN<b>, WFXRKJIKYCT<b>, JGWVUYIBRSU where a : DVNCMZHBWFJ<a, b, c> where c : IMessage<c>
	{
		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public abstract bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public abstract b Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2B334D0", Offset = "0x2B326D0", VA = "0x182B334D0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x409FC70", Offset = "0x409EE70", VA = "0x18409FC70")]
		public DVNCMZHBWFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x409FEA0", Offset = "0x409F0A0", VA = "0x18409FEA0")]
		public DVNCMZHBWFJ(bool a, [NotNull] b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x409F6E0", Offset = "0x409E8E0", VA = "0x18409F6E0", Slot = "15")]
		public void JBKGWDQRZIV(WFXRKJIKYCT<b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x409F280", Offset = "0x409E480", VA = "0x18409F280", Slot = "16")]
		public void Copy(WFXRKJIKYCT<b> other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x409FBE0", Offset = "0x409EDE0", VA = "0x18409FBE0", Slot = "17")]
		public virtual void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract c HKAJNIKMUBC();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void TABXRZRXMCI(c a);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void FQYIBJBSZJJ(byte[] a);
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class SerializedMutableOverridableBase<T, InnerType, ProtobufType> : DVNCMZHBWFJ<T, InnerType, ProtobufType> where T : DVNCMZHBWFJ<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private InnerType value;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xB0C710", Offset = "0xB0B910", VA = "0x180B0C710", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xBBFE90", Offset = "0xBBF090", VA = "0x180BBFE90", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xD125A0", Offset = "0xD117A0", VA = "0x180D125A0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5F9B030", Offset = "0x5F9A230", VA = "0x185F9B030")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5F9B1D0", Offset = "0x5F9A3D0", VA = "0x185F9B1D0")]
		public SerializedMutableOverridableBase(bool overrides, InnerType value)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, FYSIZLAMUUS>
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x83EFE50", Offset = "0x83EF050", VA = "0x1883EFE50")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x83EFEB0", Offset = "0x83EF0B0", VA = "0x1883EFEB0")]
		public MutableOverridableObscuredInt(bool overrides, ObscuredInt value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x83EFD90", Offset = "0x83EEF90", VA = "0x1883EFD90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x83EFB30", Offset = "0x83EED30", VA = "0x1883EFB30", Slot = "20")]
		public override void FQYIBJBSZJJ(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x83EFCE0", Offset = "0x83EEEE0", VA = "0x1883EFCE0", Slot = "19")]
		public override void TABXRZRXMCI(FYSIZLAMUUS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x83EFC00", Offset = "0x83EEE00", VA = "0x1883EFC00", Slot = "18")]
		public override FYSIZLAMUUS HKAJNIKMUBC()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, ANGWRSHCUZH>
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x83EFA60", Offset = "0x83EEC60", VA = "0x1883EFA60")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x83EFAC0", Offset = "0x83EECC0", VA = "0x1883EFAC0")]
		public MutableOverridableObscuredFloat(bool overrides, ObscuredFloat value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x83EF990", Offset = "0x83EEB90", VA = "0x1883EF990", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x83EF710", Offset = "0x83EE910", VA = "0x1883EF710", Slot = "20")]
		public override void FQYIBJBSZJJ(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x83EF8D0", Offset = "0x83EEAD0", VA = "0x1883EF8D0", Slot = "19")]
		public override void TABXRZRXMCI(ANGWRSHCUZH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x83EF7E0", Offset = "0x83EE9E0", VA = "0x1883EF7E0", Slot = "18")]
		public override ANGWRSHCUZH HKAJNIKMUBC()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, CJAUPMIQJIV>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x83EE990", Offset = "0x83EDB90", VA = "0x1883EE990")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x83EF6A0", Offset = "0x83EE8A0", VA = "0x1883EF6A0")]
		public MutableOverridableObscuredBool(bool overrides, ObscuredBool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x83EF5D0", Offset = "0x83EE7D0", VA = "0x1883EF5D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x83EF2D0", Offset = "0x83EE4D0", VA = "0x1883EF2D0", Slot = "20")]
		public override void FQYIBJBSZJJ(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x83EF510", Offset = "0x83EE710", VA = "0x1883EF510", Slot = "19")]
		public override void TABXRZRXMCI(CJAUPMIQJIV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x83EF3A0", Offset = "0x83EE5A0", VA = "0x1883EF3A0", Slot = "18")]
		public override CJAUPMIQJIV HKAJNIKMUBC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x83EF480", Offset = "0x83EE680", VA = "0x1883EF480", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, PGOWMFRSRCA<ObscuredBool>, CZTXUKWNXJN<ObscuredBool>, WFXRKJIKYCT<ObscuredBool>, JGWVUYIBRSU
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xABE620", Offset = "0xABD820", VA = "0x180ABE620", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xABE600", Offset = "0xABD800", VA = "0x180ABE600", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x83EE990", Offset = "0x83EDB90", VA = "0x1883EE990")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x83EE910", Offset = "0x83EDB10", VA = "0x1883EE910")]
		public void JBKGWDQRZIV(MutableOverridableDefaultableObscuredBool a)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, FYSIZLAMUUS> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x5F9BC40", Offset = "0x5F9AE40", VA = "0x185F9BC40", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x5F9BED0", Offset = "0x5F9B0D0", VA = "0x185F9BED0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5F9BB90", Offset = "0x5F9AD90", VA = "0x185F9BB90")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5F9BC10", Offset = "0x5F9AE10", VA = "0x185F9BC10")]
		public SerializedMutableOverridableObscuredEnum(bool overrides, TObsEnum value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5F9B7C0", Offset = "0x5F9A9C0", VA = "0x185F9B7C0", Slot = "18")]
		public sealed override FYSIZLAMUUS HKAJNIKMUBC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5F9B980", Offset = "0x5F9AB80", VA = "0x185F9B980", Slot = "19")]
		public sealed override void TABXRZRXMCI(FYSIZLAMUUS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5F9B5E0", Offset = "0x5F9A7E0", VA = "0x185F9B5E0", Slot = "20")]
		public sealed override void FQYIBJBSZJJ(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5F9B920", Offset = "0x5F9AB20", VA = "0x185F9B920", Slot = "17")]
		public sealed override void Reset()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, SJJZVHSRHHW>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x83EF200", Offset = "0x83EE400", VA = "0x1883EF200", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x83EF240", Offset = "0x83EE440", VA = "0x1883EF240", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x83EF170", Offset = "0x83EE370", VA = "0x1883EF170")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x83EF110", Offset = "0x83EE310", VA = "0x1883EF110")]
		public MutableOverridableListObscuredString(bool overrides, List<ObscuredString> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x83EF080", Offset = "0x83EE280", VA = "0x1883EF080", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x83EECB0", Offset = "0x83EDEB0", VA = "0x1883EECB0", Slot = "17")]
		public override void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x83EEA00", Offset = "0x83EDC00", VA = "0x1883EEA00", Slot = "20")]
		public override void FQYIBJBSZJJ(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x83EED40", Offset = "0x83EDF40", VA = "0x1883EED40", Slot = "19")]
		public override void TABXRZRXMCI(SJJZVHSRHHW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x83EEAD0", Offset = "0x83EDCD0", VA = "0x1883EEAD0", Slot = "18")]
		public override SJJZVHSRHHW HKAJNIKMUBC()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct OverridableVector3 : WFXRKJIKYCT<Vector3>, JGWVUYIBRSU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		private Vector3 value;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xE54D90", Offset = "0xE53F90", VA = "0x180E54D90", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x83F0180", Offset = "0x83EF380", VA = "0x1883F0180", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xB15770", Offset = "0xB14970", VA = "0x180B15770", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5A721C0", Offset = "0x5A713C0", VA = "0x185A721C0")]
		public OverridableVector3(Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x64848F0", Offset = "0x6483AF0", VA = "0x1864848F0")]
		public OverridableVector3(bool overrides, Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x83F00E0", Offset = "0x83EF2E0", VA = "0x1883F00E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x83F01D0", Offset = "0x83EF3D0", VA = "0x1883F01D0")]
		public static implicit operator OverridableVector3(Vector3 val)
		{
			return default(OverridableVector3);
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
