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
public interface POMPIKOAJPK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool POHEAGKBMNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object DKNJDIFOJOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NLGMLJBCNFJ<T> : POMPIKOAJPK
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T BDJLGAHJNPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BPDGIBIFOHB<T> : NLGMLJBCNFJ<T>, POMPIKOAJPK
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool POHEAGKBMNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T BDJLGAHJNPH
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
public interface NGCCPNFHPPD<T> : BPDGIBIFOHB<T>, NLGMLJBCNFJ<T>, POMPIKOAJPK
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool PKHBNAADFAM
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
	public struct OverridableInt : NLGMLJBCNFJ<int>, POMPIKOAJPK
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
			[Cpp2IlInjected.Address(RVA = "0x1045C40", Offset = "0x1044C40", VA = "0x181045C40", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x812E720", Offset = "0x812D720", VA = "0x18812E720", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x314D220", Offset = "0x314C220", VA = "0x18314D220", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x812E680", Offset = "0x812D680", VA = "0x18812E680", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : NLGMLJBCNFJ<string>, POMPIKOAJPK
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
			[Cpp2IlInjected.Address(RVA = "0x1045C40", Offset = "0x1044C40", VA = "0x181045C40", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xAEAB70", Offset = "0xAE9B70", VA = "0x180AEAB70", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAEAB70", Offset = "0xAE9B70", VA = "0x180AEAB70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x812E770", Offset = "0x812D770", VA = "0x18812E770", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : BPDGIBIFOHB<InnerType>, NLGMLJBCNFJ<InnerType>, POMPIKOAJPK where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool POHEAGKBMNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType BDJLGAHJNPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object DKNJDIFOJOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2C5DEA0", Offset = "0x2C5CEA0", VA = "0x182C5DEA0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5750990", Offset = "0x574F990", VA = "0x185750990")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x57509C0", Offset = "0x574F9C0", VA = "0x1857509C0")]
		public MutableOverridableBase(bool PJGAJPGOEEA, [NotNull] InnerType IOALKPFEKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5750450", Offset = "0x574F450", VA = "0x185750450", Slot = "15")]
		public void ENDBGLJBNLE(NLGMLJBCNFJ<InnerType> OMMNLCHPNAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x57508D0", Offset = "0x574F8D0", VA = "0x1857508D0", Slot = "16")]
		public void PBLMCCENHMO(NLGMLJBCNFJ<InnerType> EDJHHGMLKFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5750060", Offset = "0x574F060", VA = "0x185750060", Slot = "17")]
		public virtual void AEEGGHAFLLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType HBJEJKFAJPC();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void IDJOCDBBDON(ProtobufType FJJKLCGNOFA);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void OLDHKPDIFNG(byte[] MNELLPFPBMN);
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
			[Cpp2IlInjected.Address(RVA = "0xB3C200", Offset = "0xB3B200", VA = "0x180B3C200", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xB3C210", Offset = "0xB3B210", VA = "0x180B3C210", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xF28320", Offset = "0xF27320", VA = "0x180F28320", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x48B4C40", Offset = "0x48B3C40", VA = "0x1848B4C40")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5949E90", Offset = "0x5948E90", VA = "0x185949E90")]
		public SerializedMutableOverridableBase(bool PJGAJPGOEEA, InnerType IOALKPFEKEK)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, CFPIKKAPFIN>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x812E5B0", Offset = "0x812D5B0", VA = "0x18812E5B0")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x812E610", Offset = "0x812D610", VA = "0x18812E610")]
		public MutableOverridableObscuredInt(bool PJGAJPGOEEA, ObscuredInt IOALKPFEKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x812E4E0", Offset = "0x812D4E0", VA = "0x18812E4E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x812E400", Offset = "0x812D400", VA = "0x18812E400", Slot = "20")]
		public override void OLDHKPDIFNG(byte[] MNELLPFPBMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x812E350", Offset = "0x812D350", VA = "0x18812E350", Slot = "19")]
		public override void IDJOCDBBDON(CFPIKKAPFIN FJJKLCGNOFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x812E270", Offset = "0x812D270", VA = "0x18812E270", Slot = "18")]
		public override CFPIKKAPFIN HBJEJKFAJPC()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, IDKFBPLOGKI>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x812E1A0", Offset = "0x812D1A0", VA = "0x18812E1A0")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x812E200", Offset = "0x812D200", VA = "0x18812E200")]
		public MutableOverridableObscuredFloat(bool PJGAJPGOEEA, ObscuredFloat IOALKPFEKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x812E0D0", Offset = "0x812D0D0", VA = "0x18812E0D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x812DFF0", Offset = "0x812CFF0", VA = "0x18812DFF0", Slot = "20")]
		public override void OLDHKPDIFNG(byte[] MNELLPFPBMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x812DF30", Offset = "0x812CF30", VA = "0x18812DF30", Slot = "19")]
		public override void IDJOCDBBDON(IDKFBPLOGKI FJJKLCGNOFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x812DE40", Offset = "0x812CE40", VA = "0x18812DE40", Slot = "18")]
		public override IDKFBPLOGKI HBJEJKFAJPC()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, LHGGKFMPAAO>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x812D050", Offset = "0x812C050", VA = "0x18812D050")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x812DDD0", Offset = "0x812CDD0", VA = "0x18812DDD0")]
		public MutableOverridableObscuredBool(bool PJGAJPGOEEA, ObscuredBool IOALKPFEKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x812DD00", Offset = "0x812CD00", VA = "0x18812DD00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x812DB90", Offset = "0x812CB90", VA = "0x18812DB90", Slot = "20")]
		public override void OLDHKPDIFNG(byte[] MNELLPFPBMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x812DAD0", Offset = "0x812CAD0", VA = "0x18812DAD0", Slot = "19")]
		public override void IDJOCDBBDON(LHGGKFMPAAO FJJKLCGNOFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x812D9E0", Offset = "0x812C9E0", VA = "0x18812D9E0", Slot = "18")]
		public override LHGGKFMPAAO HBJEJKFAJPC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x812DC70", Offset = "0x812CC70", VA = "0x18812DC70", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, NGCCPNFHPPD<ObscuredBool>, BPDGIBIFOHB<ObscuredBool>, NLGMLJBCNFJ<ObscuredBool>, POMPIKOAJPK
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA68390", Offset = "0xA67390", VA = "0x180A68390", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA68440", Offset = "0xA67440", VA = "0x180A68440", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x812D050", Offset = "0x812C050", VA = "0x18812D050")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x812CFD0", Offset = "0x812BFD0", VA = "0x18812CFD0")]
		public void ENDBGLJBNLE(MutableOverridableDefaultableObscuredBool EDJHHGMLKFA)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, CFPIKKAPFIN> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x5C9B810", Offset = "0x5C9A810", VA = "0x185C9B810", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x5C9B920", Offset = "0x5C9A920", VA = "0x185C9B920", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x48F9010", Offset = "0x48F8010", VA = "0x1848F9010")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5C9B7F0", Offset = "0x5C9A7F0", VA = "0x185C9B7F0")]
		public SerializedMutableOverridableObscuredEnum(bool PJGAJPGOEEA, TObsEnum IOALKPFEKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5C9B520", Offset = "0x5C9A520", VA = "0x185C9B520", Slot = "18")]
		public sealed override CFPIKKAPFIN HBJEJKFAJPC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5C9B610", Offset = "0x5C9A610", VA = "0x185C9B610", Slot = "19")]
		public sealed override void IDJOCDBBDON(CFPIKKAPFIN FJJKLCGNOFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5C9B710", Offset = "0x5C9A710", VA = "0x185C9B710", Slot = "20")]
		public sealed override void OLDHKPDIFNG(byte[] MNELLPFPBMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5C9B4B0", Offset = "0x5C9A4B0", VA = "0x185C9B4B0", Slot = "17")]
		public sealed override void AEEGGHAFLLE()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, NIMGNOFPBMC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x812D910", Offset = "0x812C910", VA = "0x18812D910", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x812D950", Offset = "0x812C950", VA = "0x18812D950", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x812D870", Offset = "0x812C870", VA = "0x18812D870")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x812D810", Offset = "0x812C810", VA = "0x18812D810")]
		public MutableOverridableListObscuredString(bool PJGAJPGOEEA, List<ObscuredString> IOALKPFEKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x812D770", Offset = "0x812C770", VA = "0x18812D770", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x812D0C0", Offset = "0x812C0C0", VA = "0x18812D0C0", Slot = "17")]
		public override void AEEGGHAFLLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x812D690", Offset = "0x812C690", VA = "0x18812D690", Slot = "20")]
		public override void OLDHKPDIFNG(byte[] MNELLPFPBMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x812D330", Offset = "0x812C330", VA = "0x18812D330", Slot = "19")]
		public override void IDJOCDBBDON(NIMGNOFPBMC FJJKLCGNOFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x812D150", Offset = "0x812C150", VA = "0x18812D150", Slot = "18")]
		public override NIMGNOFPBMC HBJEJKFAJPC()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : NLGMLJBCNFJ<Vector3>, POMPIKOAJPK
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
			[Cpp2IlInjected.Address(RVA = "0x1045C40", Offset = "0x1044C40", VA = "0x181045C40", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x812E8A0", Offset = "0x812D8A0", VA = "0x18812E8A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAB6B30", Offset = "0xAB5B30", VA = "0x180AB6B30", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x587BBA0", Offset = "0x587ABA0", VA = "0x18587BBA0")]
		public OverridableVector3(Vector3 IOALKPFEKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5FBCAD0", Offset = "0x5FBBAD0", VA = "0x185FBCAD0")]
		public OverridableVector3(bool PJGAJPGOEEA, Vector3 IOALKPFEKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x812E800", Offset = "0x812D800", VA = "0x18812E800", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x812E7E0", Offset = "0x812D7E0", VA = "0x18812E7E0")]
		public static OverridableVector3 MJOOONLKLLN(Vector3 GHNFCHHGJAG)
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
