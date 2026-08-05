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
public interface BHEHEOBKEGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FJEPEGMNGML
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object IFKBOLFDFIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FLLHAKIIGMB<T> : BHEHEOBKEGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T JKEIFELLNME
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface MPODBBBHNHG<T> : FLLHAKIIGMB<T>, BHEHEOBKEGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool FJEPEGMNGML
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T JKEIFELLNME
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
public interface NKONIEGOBBG<T> : MPODBBBHNHG<T>, FLLHAKIIGMB<T>, BHEHEOBKEGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool OHEIEOHCPJB
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
	public struct OverridableInt : FLLHAKIIGMB<int>, BHEHEOBKEGJ
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
			[Cpp2IlInjected.Address(RVA = "0xA9E5F0", Offset = "0xA9D9F0", VA = "0x180A9E5F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6DAD8E0", Offset = "0x6DACCE0", VA = "0x186DAD8E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x27EC6E0", Offset = "0x27EBAE0", VA = "0x1827EC6E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6DAD840", Offset = "0x6DACC40", VA = "0x186DAD840", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : FLLHAKIIGMB<string>, BHEHEOBKEGJ
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
			[Cpp2IlInjected.Address(RVA = "0xA9E5F0", Offset = "0xA9D9F0", VA = "0x180A9E5F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x93F120", Offset = "0x93E520", VA = "0x18093F120", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x93F120", Offset = "0x93E520", VA = "0x18093F120", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6DAD930", Offset = "0x6DACD30", VA = "0x186DAD930", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : MPODBBBHNHG<InnerType>, FLLHAKIIGMB<InnerType>, BHEHEOBKEGJ where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool FJEPEGMNGML
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType JKEIFELLNME
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object IFKBOLFDFIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x23CEC80", Offset = "0x23CE080", VA = "0x1823CEC80", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x488FA40", Offset = "0x488EE40", VA = "0x18488FA40")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x488FA70", Offset = "0x488EE70", VA = "0x18488FA70")]
		public MutableOverridableBase(bool GKABPJFHGEF, [NotNull] InnerType LIHHDPOHLDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x488F340", Offset = "0x488E740", VA = "0x18488F340", Slot = "15")]
		public void BENLJKOHJBD(FLLHAKIIGMB<InnerType> HENKDDALBFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x488F840", Offset = "0x488EC40", VA = "0x18488F840", Slot = "16")]
		public void CAOLCICLPPL(FLLHAKIIGMB<InnerType> OCKBFCIKBEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x488F1D0", Offset = "0x488E5D0", VA = "0x18488F1D0", Slot = "17")]
		public virtual void AEAEDDMNDLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType HPHLAINDAMP();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void IJHMCLLDBCA(ProtobufType NAPDJHIHMHH);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void HENBCHMFKFF(byte[] OFKEAADMKLM);
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
			[Cpp2IlInjected.Address(RVA = "0x918830", Offset = "0x917C30", VA = "0x180918830", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x9822A0", Offset = "0x9816A0", VA = "0x1809822A0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x9822B0", Offset = "0x9816B0", VA = "0x1809822B0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3EEB290", Offset = "0x3EEA690", VA = "0x183EEB290")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4D6E5F0", Offset = "0x4D6D9F0", VA = "0x184D6E5F0")]
		public SerializedMutableOverridableBase(bool GKABPJFHGEF, InnerType LIHHDPOHLDK)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, HNGABOAGFON>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6DAD770", Offset = "0x6DACB70", VA = "0x186DAD770")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6DAD7D0", Offset = "0x6DACBD0", VA = "0x186DAD7D0")]
		public MutableOverridableObscuredInt(bool GKABPJFHGEF, ObscuredInt LIHHDPOHLDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6DAD6A0", Offset = "0x6DACAA0", VA = "0x186DAD6A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6DAD440", Offset = "0x6DAC840", VA = "0x186DAD440", Slot = "20")]
		public override void HENBCHMFKFF(byte[] OFKEAADMKLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6DAD5F0", Offset = "0x6DAC9F0", VA = "0x186DAD5F0", Slot = "19")]
		public override void IJHMCLLDBCA(HNGABOAGFON NAPDJHIHMHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6DAD510", Offset = "0x6DAC910", VA = "0x186DAD510", Slot = "18")]
		public override HNGABOAGFON HPHLAINDAMP()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, IFKBKPNJEGJ>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6DAD370", Offset = "0x6DAC770", VA = "0x186DAD370")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6DAD3D0", Offset = "0x6DAC7D0", VA = "0x186DAD3D0")]
		public MutableOverridableObscuredFloat(bool GKABPJFHGEF, ObscuredFloat LIHHDPOHLDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6DAD2A0", Offset = "0x6DAC6A0", VA = "0x186DAD2A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6DAD020", Offset = "0x6DAC420", VA = "0x186DAD020", Slot = "20")]
		public override void HENBCHMFKFF(byte[] OFKEAADMKLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6DAD1E0", Offset = "0x6DAC5E0", VA = "0x186DAD1E0", Slot = "19")]
		public override void IJHMCLLDBCA(IFKBKPNJEGJ NAPDJHIHMHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6DAD0F0", Offset = "0x6DAC4F0", VA = "0x186DAD0F0", Slot = "18")]
		public override IFKBKPNJEGJ HPHLAINDAMP()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, KGANHNJEHBN>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6DAC240", Offset = "0x6DAB640", VA = "0x186DAC240")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6DACFB0", Offset = "0x6DAC3B0", VA = "0x186DACFB0")]
		public MutableOverridableObscuredBool(bool GKABPJFHGEF, ObscuredBool LIHHDPOHLDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6DACEE0", Offset = "0x6DAC2E0", VA = "0x186DACEE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6DACBD0", Offset = "0x6DABFD0", VA = "0x186DACBD0", Slot = "20")]
		public override void HENBCHMFKFF(byte[] OFKEAADMKLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6DACD90", Offset = "0x6DAC190", VA = "0x186DACD90", Slot = "19")]
		public override void IJHMCLLDBCA(KGANHNJEHBN NAPDJHIHMHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6DACCA0", Offset = "0x6DAC0A0", VA = "0x186DACCA0", Slot = "18")]
		public override KGANHNJEHBN HPHLAINDAMP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6DACE50", Offset = "0x6DAC250", VA = "0x186DACE50", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, NKONIEGOBBG<ObscuredBool>, MPODBBBHNHG<ObscuredBool>, FLLHAKIIGMB<ObscuredBool>, BHEHEOBKEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8B80B0", Offset = "0x8B74B0", VA = "0x1808B80B0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8B82B0", Offset = "0x8B76B0", VA = "0x1808B82B0", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6DAC240", Offset = "0x6DAB640", VA = "0x186DAC240")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6DAC1C0", Offset = "0x6DAB5C0", VA = "0x186DAC1C0")]
		public void BENLJKOHJBD(MutableOverridableDefaultableObscuredBool OCKBFCIKBEN)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, HNGABOAGFON> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x4D6EA80", Offset = "0x4D6DE80", VA = "0x184D6EA80", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x4D6EC20", Offset = "0x4D6E020", VA = "0x184D6EC20", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3B77180", Offset = "0x3B76580", VA = "0x183B77180")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4D6EA40", Offset = "0x4D6DE40", VA = "0x184D6EA40")]
		public SerializedMutableOverridableObscuredEnum(bool GKABPJFHGEF, TObsEnum LIHHDPOHLDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4D6E850", Offset = "0x4D6DC50", VA = "0x184D6E850", Slot = "18")]
		public sealed override HNGABOAGFON HPHLAINDAMP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4D6E940", Offset = "0x4D6DD40", VA = "0x184D6E940", Slot = "19")]
		public sealed override void IJHMCLLDBCA(HNGABOAGFON NAPDJHIHMHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4D6E770", Offset = "0x4D6DB70", VA = "0x184D6E770", Slot = "20")]
		public sealed override void HENBCHMFKFF(byte[] OFKEAADMKLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4D6E6F0", Offset = "0x4D6DAF0", VA = "0x184D6E6F0", Slot = "17")]
		public sealed override void AEAEDDMNDLB()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, BIODIJBNPGO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6DACB00", Offset = "0x6DABF00", VA = "0x186DACB00", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6DACB40", Offset = "0x6DABF40", VA = "0x186DACB40", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6DACA60", Offset = "0x6DABE60", VA = "0x186DACA60")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6DACA00", Offset = "0x6DABE00", VA = "0x186DACA00")]
		public MutableOverridableListObscuredString(bool GKABPJFHGEF, List<ObscuredString> LIHHDPOHLDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6DAC960", Offset = "0x6DABD60", VA = "0x186DAC960", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6DAC2B0", Offset = "0x6DAB6B0", VA = "0x186DAC2B0", Slot = "17")]
		public override void AEAEDDMNDLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6DAC340", Offset = "0x6DAB740", VA = "0x186DAC340", Slot = "20")]
		public override void HENBCHMFKFF(byte[] OFKEAADMKLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6DAC5F0", Offset = "0x6DAB9F0", VA = "0x186DAC5F0", Slot = "19")]
		public override void IJHMCLLDBCA(BIODIJBNPGO NAPDJHIHMHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6DAC410", Offset = "0x6DAB810", VA = "0x186DAC410", Slot = "18")]
		public override BIODIJBNPGO HPHLAINDAMP()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : FLLHAKIIGMB<Vector3>, BHEHEOBKEGJ
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
			[Cpp2IlInjected.Address(RVA = "0xA9E5F0", Offset = "0xA9D9F0", VA = "0x180A9E5F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6DADA60", Offset = "0x6DACE60", VA = "0x186DADA60", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x45BCE60", Offset = "0x45BC260", VA = "0x1845BCE60", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4A2C740", Offset = "0x4A2BB40", VA = "0x184A2C740")]
		public OverridableVector3(Vector3 LIHHDPOHLDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x502AEA0", Offset = "0x502A2A0", VA = "0x18502AEA0")]
		public OverridableVector3(bool GKABPJFHGEF, Vector3 LIHHDPOHLDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6DAD9C0", Offset = "0x6DACDC0", VA = "0x186DAD9C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6DAD9A0", Offset = "0x6DACDA0", VA = "0x186DAD9A0")]
		public static OverridableVector3 ICFKEBCLOFF(Vector3 HMBPNLCBEEJ)
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
