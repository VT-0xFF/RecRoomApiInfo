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
public interface CENOLDEDOCF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool OKJEHKLJAJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object DAPMIBHBMGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NFIFANOLKNN<T> : CENOLDEDOCF
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T MHMGLCIOEKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface PEAMFOFFKJG<T> : global::NFIFANOLKNN<T>, CENOLDEDOCF
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool OKJEHKLJAJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T MHMGLCIOEKC
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
public interface BCIKPDOBKMG<T> : global::PEAMFOFFKJG<T>, global::NFIFANOLKNN<T>, CENOLDEDOCF
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool BMIAEEIOLBC
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
	public struct OverridableInt : global::NFIFANOLKNN<int>, CENOLDEDOCF
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
			[Cpp2IlInjected.Address(RVA = "0x8EE3A0", Offset = "0x8ED1A0", VA = "0x1808EE3A0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x21B1E60", Offset = "0x21B0C60", VA = "0x1821B1E60", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8D2D90", Offset = "0x8D1B90", VA = "0x1808D2D90", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x21B1DC0", Offset = "0x21B0BC0", VA = "0x1821B1DC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : global::NFIFANOLKNN<string>, CENOLDEDOCF
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
			[Cpp2IlInjected.Address(RVA = "0x8EE3A0", Offset = "0x8ED1A0", VA = "0x1808EE3A0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x804EC0", Offset = "0x803CC0", VA = "0x180804EC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x804EC0", Offset = "0x803CC0", VA = "0x180804EC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x21B1EB0", Offset = "0x21B0CB0", VA = "0x1821B1EB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : global::PEAMFOFFKJG<InnerType>, global::NFIFANOLKNN<InnerType>, CENOLDEDOCF where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool OKJEHKLJAJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType MHMGLCIOEKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object DAPMIBHBMGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x35C7DC0", Offset = "0x35C6BC0", VA = "0x1835C7DC0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x37F4680", Offset = "0x37F3480", VA = "0x1837F4680")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x37F4740", Offset = "0x37F3540", VA = "0x1837F4740")]
		public MutableOverridableBase(bool MDIGFPPNFDH, [NotNull] InnerType DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x37F3DC0", Offset = "0x37F2BC0", VA = "0x1837F3DC0", Slot = "15")]
		public void BGMCBBPKNAI(global::NFIFANOLKNN<InnerType> FCGCKAMCDGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x37F44B0", Offset = "0x37F32B0", VA = "0x1837F44B0", Slot = "16")]
		public void PCMCEDJAJPL(global::NFIFANOLKNN<InnerType> BNIMMCIKNIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x37F3FE0", Offset = "0x37F2DE0", VA = "0x1837F3FE0", Slot = "17")]
		public virtual void FLOLCMPEDIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType KPAEBBPBFFK();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void JLOKMMLKICF(ProtobufType NPIPOLNENAN);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void EJIKAELJGOD(byte[] EIODDLIMCDG);
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
			[Cpp2IlInjected.Address(RVA = "0x8E8110", Offset = "0x8E6F10", VA = "0x1808E8110", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8FE020", Offset = "0x8FCE20", VA = "0x1808FE020", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x33822D0", Offset = "0x33810D0", VA = "0x1833822D0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x274F730", Offset = "0x274E530", VA = "0x18274F730")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3C84CE0", Offset = "0x3C83AE0", VA = "0x183C84CE0")]
		public SerializedMutableOverridableBase(bool MDIGFPPNFDH, InnerType DPJGMDFEIDL)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, LONHAKKBOLK>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x21B1D60", Offset = "0x21B0B60", VA = "0x1821B1D60")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x21B1CF0", Offset = "0x21B0AF0", VA = "0x1821B1CF0")]
		public MutableOverridableObscuredInt(bool MDIGFPPNFDH, ObscuredInt DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x21B1C20", Offset = "0x21B0A20", VA = "0x1821B1C20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x21B1980", Offset = "0x21B0780", VA = "0x1821B1980", Slot = "20")]
		public override void EJIKAELJGOD(byte[] EIODDLIMCDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x21B1A80", Offset = "0x21B0880", VA = "0x1821B1A80", Slot = "19")]
		public override void JLOKMMLKICF(LONHAKKBOLK NPIPOLNENAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x21B1B40", Offset = "0x21B0940", VA = "0x1821B1B40", Slot = "18")]
		public override LONHAKKBOLK KPAEBBPBFFK()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, LPNNBNHLDOG>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x21B18B0", Offset = "0x21B06B0", VA = "0x1821B18B0")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x21B1910", Offset = "0x21B0710", VA = "0x1821B1910")]
		public MutableOverridableObscuredFloat(bool MDIGFPPNFDH, ObscuredFloat DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x21B17E0", Offset = "0x21B05E0", VA = "0x1821B17E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x21B1520", Offset = "0x21B0320", VA = "0x1821B1520", Slot = "20")]
		public override void EJIKAELJGOD(byte[] EIODDLIMCDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x21B1620", Offset = "0x21B0420", VA = "0x1821B1620", Slot = "19")]
		public override void JLOKMMLKICF(LPNNBNHLDOG NPIPOLNENAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x21B16F0", Offset = "0x21B04F0", VA = "0x1821B16F0", Slot = "18")]
		public override LPNNBNHLDOG KPAEBBPBFFK()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, FBDHMHGNICB>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x21B07E0", Offset = "0x21AF5E0", VA = "0x1821B07E0")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x21B14B0", Offset = "0x21B02B0", VA = "0x1821B14B0")]
		public MutableOverridableObscuredBool(bool MDIGFPPNFDH, ObscuredBool DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x21B13E0", Offset = "0x21B01E0", VA = "0x1821B13E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x21B1100", Offset = "0x21AFF00", VA = "0x1821B1100", Slot = "20")]
		public override void EJIKAELJGOD(byte[] EIODDLIMCDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x21B1200", Offset = "0x21B0000", VA = "0x1821B1200", Slot = "19")]
		public override void JLOKMMLKICF(FBDHMHGNICB NPIPOLNENAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x21B12C0", Offset = "0x21B00C0", VA = "0x1821B12C0", Slot = "18")]
		public override FBDHMHGNICB KPAEBBPBFFK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x21B13A0", Offset = "0x21B01A0", VA = "0x1821B13A0", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, global::BCIKPDOBKMG<ObscuredBool>, global::PEAMFOFFKJG<ObscuredBool>, global::NFIFANOLKNN<ObscuredBool>, CENOLDEDOCF
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x88A3B0", Offset = "0x8891B0", VA = "0x18088A3B0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x888770", Offset = "0x887570", VA = "0x180888770", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x21B07E0", Offset = "0x21AF5E0", VA = "0x1821B07E0")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x21B0760", Offset = "0x21AF560", VA = "0x1821B0760")]
		public void BGMCBBPKNAI(MutableOverridableDefaultableObscuredBool BNIMMCIKNIE)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, LONHAKKBOLK> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x3C851C0", Offset = "0x3C83FC0", VA = "0x183C851C0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x3C852A0", Offset = "0x3C840A0", VA = "0x183C852A0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3746E30", Offset = "0x3745C30", VA = "0x183746E30")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3C85190", Offset = "0x3C83F90", VA = "0x183C85190")]
		public SerializedMutableOverridableObscuredEnum(TObsEnum DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3C85160", Offset = "0x3C83F60", VA = "0x183C85160")]
		public SerializedMutableOverridableObscuredEnum(bool MDIGFPPNFDH, TObsEnum DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3C850B0", Offset = "0x3C83EB0", VA = "0x183C850B0", Slot = "18")]
		public sealed override LONHAKKBOLK KPAEBBPBFFK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3C84FA0", Offset = "0x3C83DA0", VA = "0x183C84FA0", Slot = "19")]
		public sealed override void JLOKMMLKICF(LONHAKKBOLK NPIPOLNENAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3C84E40", Offset = "0x3C83C40", VA = "0x183C84E40", Slot = "20")]
		public sealed override void EJIKAELJGOD(byte[] EIODDLIMCDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3C84F40", Offset = "0x3C83D40", VA = "0x183C84F40", Slot = "17")]
		public sealed override void FLOLCMPEDIG()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, MNGBMCAJPBG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x21B1030", Offset = "0x21AFE30", VA = "0x1821B1030", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x21B1070", Offset = "0x21AFE70", VA = "0x1821B1070", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x21B0F40", Offset = "0x21AFD40", VA = "0x1821B0F40")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x21B0FD0", Offset = "0x21AFDD0", VA = "0x1821B0FD0")]
		public MutableOverridableListObscuredString(bool MDIGFPPNFDH, List<ObscuredString> DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x21B0EA0", Offset = "0x21AFCA0", VA = "0x1821B0EA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x21B0950", Offset = "0x21AF750", VA = "0x1821B0950", Slot = "17")]
		public override void FLOLCMPEDIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x21B0850", Offset = "0x21AF650", VA = "0x1821B0850", Slot = "20")]
		public override void EJIKAELJGOD(byte[] EIODDLIMCDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x21B09C0", Offset = "0x21AF7C0", VA = "0x1821B09C0", Slot = "19")]
		public override void JLOKMMLKICF(MNGBMCAJPBG NPIPOLNENAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x21B0CE0", Offset = "0x21AFAE0", VA = "0x1821B0CE0", Slot = "18")]
		public override MNGBMCAJPBG KPAEBBPBFFK()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : global::NFIFANOLKNN<Vector3>, CENOLDEDOCF
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
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8EE3A0", Offset = "0x8ED1A0", VA = "0x1808EE3A0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x21B2000", Offset = "0x21B0E00", VA = "0x1821B2000", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x9F4950", Offset = "0x9F3750", VA = "0x1809F4950", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x21B1FE0", Offset = "0x21B0DE0", VA = "0x1821B1FE0")]
		public OverridableVector3(Vector3 DPJGMDFEIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x21B1F40", Offset = "0x21B0D40", VA = "0x1821B1F40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x21B1F20", Offset = "0x21B0D20", VA = "0x1821B1F20")]
		public static OverridableVector3 LJJFBFNEMCH(Vector3 OAFEANCCICI)
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
