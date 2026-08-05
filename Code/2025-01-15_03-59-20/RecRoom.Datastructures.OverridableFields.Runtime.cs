using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using Cpp2IlInjected;
using Google.Protobuf;
using JetBrains.Annotations;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface GFDPNABICOB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DBAKNJCEGOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object APADGGMHOCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface AGDBDBIPDMB<T> : GFDPNABICOB
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T GFHLLJBPNAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface ODOHCAICJPE<T> : AGDBDBIPDMB<T>, GFDPNABICOB
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool DBAKNJCEGOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T GFHLLJBPNAP
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
public interface CKCNMCLOANF<T> : ODOHCAICJPE<T>, AGDBDBIPDMB<T>, GFDPNABICOB
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool HMFGAAEEGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
namespace RecRoom.Utils.OverridableFields
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct OverridableInt : AGDBDBIPDMB<int>, GFDPNABICOB
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
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xB13E00", Offset = "0xB13200", VA = "0x180B13E00", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6FBD8C0", Offset = "0x6FBCCC0", VA = "0x186FBD8C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x293B520", Offset = "0x293A920", VA = "0x18293B520", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD820", Offset = "0x6FBCC20", VA = "0x186FBD820", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : AGDBDBIPDMB<string>, GFDPNABICOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private string value;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xB13E00", Offset = "0xB13200", VA = "0x180B13E00", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9C07A0", Offset = "0x9BFBA0", VA = "0x1809C07A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9C07A0", Offset = "0x9BFBA0", VA = "0x1809C07A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD910", Offset = "0x6FBCD10", VA = "0x186FBD910", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : ODOHCAICJPE<InnerType>, AGDBDBIPDMB<InnerType>, GFDPNABICOB where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool DBAKNJCEGOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType GFHLLJBPNAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object APADGGMHOCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x24E00D0", Offset = "0x24DF4D0", VA = "0x1824E00D0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4A59F80", Offset = "0x4A59380", VA = "0x184A59F80")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4A59FB0", Offset = "0x4A593B0", VA = "0x184A59FB0")]
		public MutableOverridableBase(bool ONDCOCHIGLH, [NotNull] InnerType HCPAOILCJCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4A59C40", Offset = "0x4A59040", VA = "0x184A59C40", Slot = "15")]
		public void MAALFPNBBNK(AGDBDBIPDMB<InnerType> GBMGFIEPMIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4A597C0", Offset = "0x4A58BC0", VA = "0x184A597C0", Slot = "16")]
		public void JFAPBEGNFEK(AGDBDBIPDMB<InnerType> BMKPAKCEMFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4A595F0", Offset = "0x4A589F0", VA = "0x184A595F0", Slot = "17")]
		public virtual void CALNFFOLFJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType LKKIIKAHOAH();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void JFPDFJAMFHH(ProtobufType MEAJHGHCODC);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void GCDOBBFOMLB(byte[] NFGHPMIBDEN);
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public abstract class SerializedMutableOverridableBase<T, InnerType, ProtobufType> : MutableOverridableBase<T, InnerType, ProtobufType> where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		private InnerType value;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x9617B0", Offset = "0x960BB0", VA = "0x1809617B0", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x96FE20", Offset = "0x96F220", VA = "0x18096FE20", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA10B80", Offset = "0xA0FF80", VA = "0x180A10B80", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x40529C0", Offset = "0x4051DC0", VA = "0x1840529C0")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x426C0F0", Offset = "0x426B4F0", VA = "0x18426C0F0")]
		public SerializedMutableOverridableBase(bool ONDCOCHIGLH, InnerType HCPAOILCJCB)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, PPCKMNJAJBD>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD750", Offset = "0x6FBCB50", VA = "0x186FBD750")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD7B0", Offset = "0x6FBCBB0", VA = "0x186FBD7B0")]
		public MutableOverridableObscuredInt(bool ONDCOCHIGLH, ObscuredInt HCPAOILCJCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD680", Offset = "0x6FBCA80", VA = "0x186FBD680", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD420", Offset = "0x6FBC820", VA = "0x186FBD420", Slot = "20")]
		public override void GCDOBBFOMLB(byte[] NFGHPMIBDEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD4F0", Offset = "0x6FBC8F0", VA = "0x186FBD4F0", Slot = "19")]
		public override void JFPDFJAMFHH(PPCKMNJAJBD MEAJHGHCODC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD5A0", Offset = "0x6FBC9A0", VA = "0x186FBD5A0", Slot = "18")]
		public override PPCKMNJAJBD LKKIIKAHOAH()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, DKKECALJOAM>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD350", Offset = "0x6FBC750", VA = "0x186FBD350")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD3B0", Offset = "0x6FBC7B0", VA = "0x186FBD3B0")]
		public MutableOverridableObscuredFloat(bool ONDCOCHIGLH, ObscuredFloat HCPAOILCJCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD280", Offset = "0x6FBC680", VA = "0x186FBD280", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD000", Offset = "0x6FBC400", VA = "0x186FBD000", Slot = "20")]
		public override void GCDOBBFOMLB(byte[] NFGHPMIBDEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD0D0", Offset = "0x6FBC4D0", VA = "0x186FBD0D0", Slot = "19")]
		public override void JFPDFJAMFHH(DKKECALJOAM MEAJHGHCODC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD190", Offset = "0x6FBC590", VA = "0x186FBD190", Slot = "18")]
		public override DKKECALJOAM LKKIIKAHOAH()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, EPFANPFMEPO>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6FBC230", Offset = "0x6FBB630", VA = "0x186FBC230")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6FBCF90", Offset = "0x6FBC390", VA = "0x186FBCF90")]
		public MutableOverridableObscuredBool(bool ONDCOCHIGLH, ObscuredBool HCPAOILCJCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6FBCEC0", Offset = "0x6FBC2C0", VA = "0x186FBCEC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6FBCBB0", Offset = "0x6FBBFB0", VA = "0x186FBCBB0", Slot = "20")]
		public override void GCDOBBFOMLB(byte[] NFGHPMIBDEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6FBCC80", Offset = "0x6FBC080", VA = "0x186FBCC80", Slot = "19")]
		public override void JFPDFJAMFHH(EPFANPFMEPO MEAJHGHCODC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6FBCD40", Offset = "0x6FBC140", VA = "0x186FBCD40", Slot = "18")]
		public override EPFANPFMEPO LKKIIKAHOAH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6FBCE30", Offset = "0x6FBC230", VA = "0x186FBCE30", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, CKCNMCLOANF<ObscuredBool>, ODOHCAICJPE<ObscuredBool>, AGDBDBIPDMB<ObscuredBool>, GFDPNABICOB
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8D0DA0", Offset = "0x8D01A0", VA = "0x1808D0DA0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8D0DF0", Offset = "0x8D01F0", VA = "0x1808D0DF0", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6FBC230", Offset = "0x6FBB630", VA = "0x186FBC230")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6FBC1B0", Offset = "0x6FBB5B0", VA = "0x186FBC1B0")]
		public void MAALFPNBBNK(MutableOverridableDefaultableObscuredBool BMKPAKCEMFK)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, PPCKMNJAJBD> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x4EAD200", Offset = "0x4EAC600", VA = "0x184EAD200", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x4EAD3A0", Offset = "0x4EAC7A0", VA = "0x184EAD3A0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x43D82F0", Offset = "0x43D76F0", VA = "0x1843D82F0")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4EAD1C0", Offset = "0x4EAC5C0", VA = "0x184EAD1C0")]
		public SerializedMutableOverridableObscuredEnum(bool ONDCOCHIGLH, TObsEnum HCPAOILCJCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4EAD0D0", Offset = "0x4EAC4D0", VA = "0x184EAD0D0", Slot = "18")]
		public sealed override PPCKMNJAJBD LKKIIKAHOAH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4EACFD0", Offset = "0x4EAC3D0", VA = "0x184EACFD0", Slot = "19")]
		public sealed override void JFPDFJAMFHH(PPCKMNJAJBD MEAJHGHCODC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4EACEF0", Offset = "0x4EAC2F0", VA = "0x184EACEF0", Slot = "20")]
		public sealed override void GCDOBBFOMLB(byte[] NFGHPMIBDEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4EACE70", Offset = "0x4EAC270", VA = "0x184EACE70", Slot = "17")]
		public sealed override void CALNFFOLFJH()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, GHEMHNBOHMI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6FBCAE0", Offset = "0x6FBBEE0", VA = "0x186FBCAE0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6FBCB20", Offset = "0x6FBBF20", VA = "0x186FBCB20", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6FBCA40", Offset = "0x6FBBE40", VA = "0x186FBCA40")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6FBC9E0", Offset = "0x6FBBDE0", VA = "0x186FBC9E0")]
		public MutableOverridableListObscuredString(bool ONDCOCHIGLH, List<ObscuredString> HCPAOILCJCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6FBC940", Offset = "0x6FBBD40", VA = "0x186FBC940", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6FBC2A0", Offset = "0x6FBB6A0", VA = "0x186FBC2A0", Slot = "17")]
		public override void CALNFFOLFJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6FBC330", Offset = "0x6FBB730", VA = "0x186FBC330", Slot = "20")]
		public override void GCDOBBFOMLB(byte[] NFGHPMIBDEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6FBC400", Offset = "0x6FBB800", VA = "0x186FBC400", Slot = "19")]
		public override void JFPDFJAMFHH(GHEMHNBOHMI MEAJHGHCODC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6FBC760", Offset = "0x6FBBB60", VA = "0x186FBC760", Slot = "18")]
		public override GHEMHNBOHMI LKKIIKAHOAH()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : AGDBDBIPDMB<Vector3>, GFDPNABICOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private Vector3 value;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xB13E00", Offset = "0xB13200", VA = "0x180B13E00", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6FBDA40", Offset = "0x6FBCE40", VA = "0x186FBDA40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x47A8540", Offset = "0x47A7940", VA = "0x1847A8540", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4B53130", Offset = "0x4B52530", VA = "0x184B53130")]
		public OverridableVector3(Vector3 HCPAOILCJCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x514E440", Offset = "0x514D840", VA = "0x18514E440")]
		public OverridableVector3(bool ONDCOCHIGLH, Vector3 HCPAOILCJCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD9A0", Offset = "0x6FBCDA0", VA = "0x186FBD9A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD980", Offset = "0x6FBCD80", VA = "0x186FBD980")]
		public static OverridableVector3 IDKOEJANABA(Vector3 BBFFJMPBBGO)
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
