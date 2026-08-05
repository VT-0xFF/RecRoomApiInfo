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
public interface BMLCEDKCAHO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool IOEINPGDFAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object MAAPEFOHFBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EMJKHGHGDFD<T> : BMLCEDKCAHO
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T GMFAJOGMKIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GDJNPBGMBGH<T> : EMJKHGHGDFD<T>, BMLCEDKCAHO
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool IOEINPGDFAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T GMFAJOGMKIF
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
public interface DNNIFIENLMD<T> : GDJNPBGMBGH<T>, EMJKHGHGDFD<T>, BMLCEDKCAHO
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool JBJFCDJBGBG
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
	public struct OverridableInt : EMJKHGHGDFD<int>, BMLCEDKCAHO
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
			[Cpp2IlInjected.Address(RVA = "0x19E3670", Offset = "0x19E2270", VA = "0x1819E3670", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5DE0D50", Offset = "0x5DDF950", VA = "0x185DE0D50", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x20A61A0", Offset = "0x20A4DA0", VA = "0x1820A61A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0CB0", Offset = "0x5DDF8B0", VA = "0x185DE0CB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : EMJKHGHGDFD<string>, BMLCEDKCAHO
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
			[Cpp2IlInjected.Address(RVA = "0x19E3670", Offset = "0x19E2270", VA = "0x1819E3670", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x834770", Offset = "0x833370", VA = "0x180834770", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x834770", Offset = "0x833370", VA = "0x180834770", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0DA0", Offset = "0x5DDF9A0", VA = "0x185DE0DA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : GDJNPBGMBGH<InnerType>, EMJKHGHGDFD<InnerType>, BMLCEDKCAHO where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool IOEINPGDFAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType GMFAJOGMKIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object MAAPEFOHFBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x3CF70C0", Offset = "0x3CF5CC0", VA = "0x183CF70C0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3CF6D80", Offset = "0x3CF5980", VA = "0x183CF6D80")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3CF6DB0", Offset = "0x3CF59B0", VA = "0x183CF6DB0")]
		public MutableOverridableBase(bool NDOKIAIEHHC, [NotNull] InnerType GCPEEAODAIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3CF6A20", Offset = "0x3CF5620", VA = "0x183CF6A20", Slot = "15")]
		public void OLPBAHOPMIP(EMJKHGHGDFD<InnerType> GNFKEPAJPCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3CF6740", Offset = "0x3CF5340", VA = "0x183CF6740", Slot = "16")]
		public void KOCALHGOPKG(EMJKHGHGDFD<InnerType> LLMHBOEDHFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3CF64B0", Offset = "0x3CF50B0", VA = "0x183CF64B0", Slot = "17")]
		public virtual void GPJBDIFOFCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType IJHKLJFKENE();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void DINIAFGMFII(ProtobufType FDKKHFJFLLA);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void DOAHMFEHPJL(byte[] HCCMONIFGEM);
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
			[Cpp2IlInjected.Address(RVA = "0x7C4240", Offset = "0x7C2E40", VA = "0x1807C4240", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x94A2A0", Offset = "0x948EA0", VA = "0x18094A2A0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1914310", Offset = "0x1912F10", VA = "0x181914310", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x318D410", Offset = "0x318C010", VA = "0x18318D410")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3180400", Offset = "0x317F000", VA = "0x183180400")]
		public SerializedMutableOverridableBase(bool NDOKIAIEHHC, InnerType GCPEEAODAIB)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, JJCMMGFFMGK>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0BE0", Offset = "0x5DDF7E0", VA = "0x185DE0BE0")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0C40", Offset = "0x5DDF840", VA = "0x185DE0C40")]
		public MutableOverridableObscuredInt(bool NDOKIAIEHHC, ObscuredInt GCPEEAODAIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0B10", Offset = "0x5DDF710", VA = "0x185DE0B10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0950", Offset = "0x5DDF550", VA = "0x185DE0950", Slot = "20")]
		public override void DOAHMFEHPJL(byte[] HCCMONIFGEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5DE08A0", Offset = "0x5DDF4A0", VA = "0x185DE08A0", Slot = "19")]
		public override void DINIAFGMFII(JJCMMGFFMGK FDKKHFJFLLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0A30", Offset = "0x5DDF630", VA = "0x185DE0A30", Slot = "18")]
		public override JJCMMGFFMGK IJHKLJFKENE()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, BEDLENECFGC>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5DE07D0", Offset = "0x5DDF3D0", VA = "0x185DE07D0")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0830", Offset = "0x5DDF430", VA = "0x185DE0830")]
		public MutableOverridableObscuredFloat(bool NDOKIAIEHHC, ObscuredFloat GCPEEAODAIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0700", Offset = "0x5DDF300", VA = "0x185DE0700", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0530", Offset = "0x5DDF130", VA = "0x185DE0530", Slot = "20")]
		public override void DOAHMFEHPJL(byte[] HCCMONIFGEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0470", Offset = "0x5DDF070", VA = "0x185DE0470", Slot = "19")]
		public override void DINIAFGMFII(BEDLENECFGC FDKKHFJFLLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0610", Offset = "0x5DDF210", VA = "0x185DE0610", Slot = "18")]
		public override BEDLENECFGC IJHKLJFKENE()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, KJAFJGGEDKD>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5DDF680", Offset = "0x5DDE280", VA = "0x185DDF680")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0400", Offset = "0x5DDF000", VA = "0x185DE0400")]
		public MutableOverridableObscuredBool(bool NDOKIAIEHHC, ObscuredBool GCPEEAODAIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0330", Offset = "0x5DDEF30", VA = "0x185DE0330", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5DE00D0", Offset = "0x5DDECD0", VA = "0x185DE00D0", Slot = "20")]
		public override void DOAHMFEHPJL(byte[] HCCMONIFGEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0010", Offset = "0x5DDEC10", VA = "0x185DE0010", Slot = "19")]
		public override void DINIAFGMFII(KJAFJGGEDKD FDKKHFJFLLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5DE01B0", Offset = "0x5DDEDB0", VA = "0x185DE01B0", Slot = "18")]
		public override KJAFJGGEDKD IJHKLJFKENE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5DE02A0", Offset = "0x5DDEEA0", VA = "0x185DE02A0", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, DNNIFIENLMD<ObscuredBool>, GDJNPBGMBGH<ObscuredBool>, EMJKHGHGDFD<ObscuredBool>, BMLCEDKCAHO
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x776670", Offset = "0x775270", VA = "0x180776670", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x776720", Offset = "0x775320", VA = "0x180776720", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5DDF680", Offset = "0x5DDE280", VA = "0x185DDF680")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5DDF600", Offset = "0x5DDE200", VA = "0x185DDF600")]
		public void OLPBAHOPMIP(MutableOverridableDefaultableObscuredBool LLMHBOEDHFP)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, JJCMMGFFMGK> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x4097330", Offset = "0x4095F30", VA = "0x184097330", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x4097460", Offset = "0x4096060", VA = "0x184097460", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3737DE0", Offset = "0x37369E0", VA = "0x183737DE0")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4097310", Offset = "0x4095F10", VA = "0x184097310")]
		public SerializedMutableOverridableObscuredEnum(bool NDOKIAIEHHC, TObsEnum GCPEEAODAIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4097220", Offset = "0x4095E20", VA = "0x184097220", Slot = "18")]
		public sealed override JJCMMGFFMGK IJHKLJFKENE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4096FD0", Offset = "0x4095BD0", VA = "0x184096FD0", Slot = "19")]
		public sealed override void DINIAFGMFII(JJCMMGFFMGK FDKKHFJFLLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x40970D0", Offset = "0x4095CD0", VA = "0x1840970D0", Slot = "20")]
		public sealed override void DOAHMFEHPJL(byte[] HCCMONIFGEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x40971B0", Offset = "0x4095DB0", VA = "0x1840971B0", Slot = "17")]
		public sealed override void GPJBDIFOFCM()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, PMKBIMOKGKA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x5DDFF40", Offset = "0x5DDEB40", VA = "0x185DDFF40", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x5DDFF80", Offset = "0x5DDEB80", VA = "0x185DDFF80", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5DDFEA0", Offset = "0x5DDEAA0", VA = "0x185DDFEA0")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5DDFE40", Offset = "0x5DDEA40", VA = "0x185DDFE40")]
		public MutableOverridableListObscuredString(bool NDOKIAIEHHC, List<ObscuredString> GCPEEAODAIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5DDFDA0", Offset = "0x5DDE9A0", VA = "0x185DDFDA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5DDFB30", Offset = "0x5DDE730", VA = "0x185DDFB30", Slot = "17")]
		public override void GPJBDIFOFCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5DDFA50", Offset = "0x5DDE650", VA = "0x185DDFA50", Slot = "20")]
		public override void DOAHMFEHPJL(byte[] HCCMONIFGEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5DDF6F0", Offset = "0x5DDE2F0", VA = "0x185DDF6F0", Slot = "19")]
		public override void DINIAFGMFII(PMKBIMOKGKA FDKKHFJFLLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5DDFBC0", Offset = "0x5DDE7C0", VA = "0x185DDFBC0", Slot = "18")]
		public override PMKBIMOKGKA IJHKLJFKENE()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : EMJKHGHGDFD<Vector3>, BMLCEDKCAHO
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
			[Cpp2IlInjected.Address(RVA = "0x19E3670", Offset = "0x19E2270", VA = "0x1819E3670", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5DE0ED0", Offset = "0x5DDFAD0", VA = "0x185DE0ED0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x3A24550", Offset = "0x3A23150", VA = "0x183A24550", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3DD1540", Offset = "0x3DD0140", VA = "0x183DD1540")]
		public OverridableVector3(Vector3 GCPEEAODAIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0E30", Offset = "0x5DDFA30", VA = "0x185DE0E30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0E10", Offset = "0x5DDFA10", VA = "0x185DE0E10")]
		public static OverridableVector3 JLFJLFEACJM(Vector3 FEGNLFKFNHA)
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
