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
public interface EFHJLPGOBLB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MIMICEDDPML
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object JEKDDPNJGEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CMFIMEGKHFG<T> : EFHJLPGOBLB
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T BHKLFFIKDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface MJJNKHACDAJ<T> : CMFIMEGKHFG<T>, EFHJLPGOBLB
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool MIMICEDDPML
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T BHKLFFIKDPE
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
public interface EFAJJMBFMKP<T> : MJJNKHACDAJ<T>, CMFIMEGKHFG<T>, EFHJLPGOBLB
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool ONKCMLHMEHA
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
	public struct OverridableInt : CMFIMEGKHFG<int>, EFHJLPGOBLB
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
			[Cpp2IlInjected.Address(RVA = "0x10830E0", Offset = "0x1081AE0", VA = "0x1810830E0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x82C1290", Offset = "0x82BFC90", VA = "0x1882C1290", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2FA5300", Offset = "0x2FA3D00", VA = "0x182FA5300", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x82C11F0", Offset = "0x82BFBF0", VA = "0x1882C11F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : CMFIMEGKHFG<string>, EFHJLPGOBLB
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
			[Cpp2IlInjected.Address(RVA = "0x10830E0", Offset = "0x1081AE0", VA = "0x1810830E0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6D0", Offset = "0xB1C0D0", VA = "0x180B1D6D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6D0", Offset = "0xB1C0D0", VA = "0x180B1D6D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x82C12E0", Offset = "0x82BFCE0", VA = "0x1882C12E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : MJJNKHACDAJ<InnerType>, CMFIMEGKHFG<InnerType>, EFHJLPGOBLB where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool MIMICEDDPML
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType BHKLFFIKDPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object JEKDDPNJGEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2CA6AC0", Offset = "0x2CA54C0", VA = "0x182CA6AC0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x588C0F0", Offset = "0x588AAF0", VA = "0x18588C0F0")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x588C120", Offset = "0x588AB20", VA = "0x18588C120")]
		public MutableOverridableBase(bool GHKIEOOIIAH, [NotNull] InnerType PDKJBMPOMNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x588BE70", Offset = "0x588A870", VA = "0x18588BE70", Slot = "15")]
		public void JNLHNGCHENA(CMFIMEGKHFG<InnerType> EJGIIDDOBIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x588B910", Offset = "0x588A310", VA = "0x18588B910", Slot = "16")]
		public void BCDPIPBINMD(CMFIMEGKHFG<InnerType> EFNHKCDKOGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x588B8D0", Offset = "0x588A2D0", VA = "0x18588B8D0", Slot = "17")]
		public virtual void AAJENMMCLHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType IBMEFFFCANK();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void COIPHKOOOGF(ProtobufType AIGPNBPHAOM);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void PCADKEGAMHI(byte[] GIACNBOEDMA);
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
			[Cpp2IlInjected.Address(RVA = "0xB50B70", Offset = "0xB4F570", VA = "0x180B50B70", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xB50B50", Offset = "0xB4F550", VA = "0x180B50B50", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xF4F6C0", Offset = "0xF4E0C0", VA = "0x180F4F6C0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x48D4670", Offset = "0x48D3070", VA = "0x1848D4670")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x49452B0", Offset = "0x4943CB0", VA = "0x1849452B0")]
		public SerializedMutableOverridableBase(bool GHKIEOOIIAH, InnerType PDKJBMPOMNC)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, AJNHGKIAAOO>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x82C1120", Offset = "0x82BFB20", VA = "0x1882C1120")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x82C1180", Offset = "0x82BFB80", VA = "0x1882C1180")]
		public MutableOverridableObscuredInt(bool GHKIEOOIIAH, ObscuredInt PDKJBMPOMNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x82C1050", Offset = "0x82BFA50", VA = "0x1882C1050", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x82C0F70", Offset = "0x82BF970", VA = "0x1882C0F70", Slot = "20")]
		public override void PCADKEGAMHI(byte[] GIACNBOEDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x82C0DE0", Offset = "0x82BF7E0", VA = "0x1882C0DE0", Slot = "19")]
		public override void COIPHKOOOGF(AJNHGKIAAOO AIGPNBPHAOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x82C0E90", Offset = "0x82BF890", VA = "0x1882C0E90", Slot = "18")]
		public override AJNHGKIAAOO IBMEFFFCANK()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, MODEOMJKNIC>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x82C0D10", Offset = "0x82BF710", VA = "0x1882C0D10")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x82C0D70", Offset = "0x82BF770", VA = "0x1882C0D70")]
		public MutableOverridableObscuredFloat(bool GHKIEOOIIAH, ObscuredFloat PDKJBMPOMNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x82C0C40", Offset = "0x82BF640", VA = "0x1882C0C40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x82C0B60", Offset = "0x82BF560", VA = "0x1882C0B60", Slot = "20")]
		public override void PCADKEGAMHI(byte[] GIACNBOEDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x82C09B0", Offset = "0x82BF3B0", VA = "0x1882C09B0", Slot = "19")]
		public override void COIPHKOOOGF(MODEOMJKNIC AIGPNBPHAOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x82C0A70", Offset = "0x82BF470", VA = "0x1882C0A70", Slot = "18")]
		public override MODEOMJKNIC IBMEFFFCANK()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, KLHDHCIBIBI>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x82BFBC0", Offset = "0x82BE5C0", VA = "0x1882BFBC0")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x82C0940", Offset = "0x82BF340", VA = "0x1882C0940")]
		public MutableOverridableObscuredBool(bool GHKIEOOIIAH, ObscuredBool PDKJBMPOMNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x82C0870", Offset = "0x82BF270", VA = "0x1882C0870", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x82C0790", Offset = "0x82BF190", VA = "0x1882C0790", Slot = "20")]
		public override void PCADKEGAMHI(byte[] GIACNBOEDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x82C0550", Offset = "0x82BEF50", VA = "0x1882C0550", Slot = "19")]
		public override void COIPHKOOOGF(KLHDHCIBIBI AIGPNBPHAOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x82C0610", Offset = "0x82BF010", VA = "0x1882C0610", Slot = "18")]
		public override KLHDHCIBIBI IBMEFFFCANK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x82C0700", Offset = "0x82BF100", VA = "0x1882C0700", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, EFAJJMBFMKP<ObscuredBool>, MJJNKHACDAJ<ObscuredBool>, CMFIMEGKHFG<ObscuredBool>, EFHJLPGOBLB
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA88540", Offset = "0xA86F40", VA = "0x180A88540", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA88520", Offset = "0xA86F20", VA = "0x180A88520", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x82BFBC0", Offset = "0x82BE5C0", VA = "0x1882BFBC0")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x82BFB40", Offset = "0x82BE540", VA = "0x1882BFB40")]
		public void JNLHNGCHENA(MutableOverridableDefaultableObscuredBool EFNHKCDKOGH)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, AJNHGKIAAOO> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x5D78F50", Offset = "0x5D77950", VA = "0x185D78F50", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x5D79080", Offset = "0x5D77A80", VA = "0x185D79080", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x492DEC0", Offset = "0x492C8C0", VA = "0x18492DEC0")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5D78F30", Offset = "0x5D77930", VA = "0x185D78F30")]
		public SerializedMutableOverridableObscuredEnum(bool GHKIEOOIIAH, TObsEnum PDKJBMPOMNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5D78D60", Offset = "0x5D77760", VA = "0x185D78D60", Slot = "18")]
		public sealed override AJNHGKIAAOO IBMEFFFCANK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5D78C60", Offset = "0x5D77660", VA = "0x185D78C60", Slot = "19")]
		public sealed override void COIPHKOOOGF(AJNHGKIAAOO AIGPNBPHAOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5D78E50", Offset = "0x5D77850", VA = "0x185D78E50", Slot = "20")]
		public sealed override void PCADKEGAMHI(byte[] GIACNBOEDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5D78BF0", Offset = "0x5D775F0", VA = "0x185D78BF0", Slot = "17")]
		public sealed override void AAJENMMCLHG()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, AHAHEMPLAKG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x82C0480", Offset = "0x82BEE80", VA = "0x1882C0480", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x82C04C0", Offset = "0x82BEEC0", VA = "0x1882C04C0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x82C03E0", Offset = "0x82BEDE0", VA = "0x1882C03E0")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x82C0380", Offset = "0x82BED80", VA = "0x1882C0380")]
		public MutableOverridableListObscuredString(bool GHKIEOOIIAH, List<ObscuredString> PDKJBMPOMNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x82C02E0", Offset = "0x82BECE0", VA = "0x1882C02E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x82BFC30", Offset = "0x82BE630", VA = "0x1882BFC30", Slot = "17")]
		public override void AAJENMMCLHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x82C0200", Offset = "0x82BEC00", VA = "0x1882C0200", Slot = "20")]
		public override void PCADKEGAMHI(byte[] GIACNBOEDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x82BFCC0", Offset = "0x82BE6C0", VA = "0x1882BFCC0", Slot = "19")]
		public override void COIPHKOOOGF(AHAHEMPLAKG AIGPNBPHAOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x82C0020", Offset = "0x82BEA20", VA = "0x1882C0020", Slot = "18")]
		public override AHAHEMPLAKG IBMEFFFCANK()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : CMFIMEGKHFG<Vector3>, EFHJLPGOBLB
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
			[Cpp2IlInjected.Address(RVA = "0x10830E0", Offset = "0x1081AE0", VA = "0x1810830E0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x82C1410", Offset = "0x82BFE10", VA = "0x1882C1410", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAD9910", Offset = "0xAD8310", VA = "0x180AD9910", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x59CA7E0", Offset = "0x59C91E0", VA = "0x1859CA7E0")]
		public OverridableVector3(Vector3 PDKJBMPOMNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x60B9060", Offset = "0x60B7A60", VA = "0x1860B9060")]
		public OverridableVector3(bool GHKIEOOIIAH, Vector3 PDKJBMPOMNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x82C1370", Offset = "0x82BFD70", VA = "0x1882C1370", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x82C1350", Offset = "0x82BFD50", VA = "0x1882C1350")]
		public static OverridableVector3 LHJBCIIELME(Vector3 BEAEDIJJJJI)
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
