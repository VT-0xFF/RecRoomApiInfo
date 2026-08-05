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
public interface HPLMEPBNFMC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool JJBNAAGMNOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object GIKMDAHAMNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MGCBLKJNMGL<T> : HPLMEPBNFMC
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T AMPEKKPGHLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface NGBGPAFAGGM<T> : global::MGCBLKJNMGL<T>, HPLMEPBNFMC
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool JJBNAAGMNOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T AMPEKKPGHLN
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
public interface KMODLEBFCBH<T> : global::NGBGPAFAGGM<T>, global::MGCBLKJNMGL<T>, HPLMEPBNFMC
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool OKEAAIMOJEJ
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
	public struct OverridableInt : global::MGCBLKJNMGL<int>, HPLMEPBNFMC
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
			[Cpp2IlInjected.Address(RVA = "0x807770", Offset = "0x806570", VA = "0x180807770", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5EA2840", Offset = "0x5EA1640", VA = "0x185EA2840", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6CF8F0", Offset = "0x6CE6F0", VA = "0x1806CF8F0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5EA27A0", Offset = "0x5EA15A0", VA = "0x185EA27A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : global::MGCBLKJNMGL<string>, HPLMEPBNFMC
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
			[Cpp2IlInjected.Address(RVA = "0x807770", Offset = "0x806570", VA = "0x180807770", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x650700", Offset = "0x64F500", VA = "0x180650700", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x650700", Offset = "0x64F500", VA = "0x180650700", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2890", Offset = "0x5EA1690", VA = "0x185EA2890", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : global::NGBGPAFAGGM<InnerType>, global::MGCBLKJNMGL<InnerType>, HPLMEPBNFMC where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool JJBNAAGMNOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType AMPEKKPGHLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object GIKMDAHAMNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2AECAB0", Offset = "0x2AEB8B0", VA = "0x182AECAB0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2AEC820", Offset = "0x2AEB620", VA = "0x182AEC820")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2AEC8E0", Offset = "0x2AEB6E0", VA = "0x182AEC8E0")]
		public MutableOverridableBase(bool PGGKNKGAGIL, [NotNull] InnerType GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2AEC050", Offset = "0x2AEAE50", VA = "0x182AEC050", Slot = "15")]
		public void EMAGKKABFEF(global::MGCBLKJNMGL<InnerType> GNICKKAPAEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2AEC650", Offset = "0x2AEB450", VA = "0x182AEC650", Slot = "16")]
		public void HBNCLABAILL(global::MGCBLKJNMGL<InnerType> MCLIMJFDMCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2AEC1D0", Offset = "0x2AEAFD0", VA = "0x182AEC1D0", Slot = "17")]
		public virtual void FBGINNLGAJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType BLJAODCPACP();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void BPJLIMDIDDK(ProtobufType PKLDEJDLNDH);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void NFGDCGKAEAG(byte[] FLJECEJDFMG);
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
			[Cpp2IlInjected.Address(RVA = "0x6CC600", Offset = "0x6CB400", VA = "0x1806CC600", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6CC620", Offset = "0x6CB420", VA = "0x1806CC620", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x16D6900", Offset = "0x16D5700", VA = "0x1816D6900", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1A89F80", Offset = "0x1A88D80", VA = "0x181A89F80")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2F0B200", Offset = "0x2F0A000", VA = "0x182F0B200")]
		public SerializedMutableOverridableBase(bool PGGKNKGAGIL, InnerType GKFICKKHACC)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, OPPDNKHODGA>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2740", Offset = "0x5EA1540", VA = "0x185EA2740")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5EA26D0", Offset = "0x5EA14D0", VA = "0x185EA26D0")]
		public MutableOverridableObscuredInt(bool PGGKNKGAGIL, ObscuredInt GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2600", Offset = "0x5EA1400", VA = "0x185EA2600", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2500", Offset = "0x5EA1300", VA = "0x185EA2500", Slot = "20")]
		public override void NFGDCGKAEAG(byte[] FLJECEJDFMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2440", Offset = "0x5EA1240", VA = "0x185EA2440", Slot = "19")]
		public override void BPJLIMDIDDK(OPPDNKHODGA PKLDEJDLNDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2360", Offset = "0x5EA1160", VA = "0x185EA2360", Slot = "18")]
		public override OPPDNKHODGA BLJAODCPACP()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, BEKKEFKJHMJ>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2290", Offset = "0x5EA1090", VA = "0x185EA2290")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5EA22F0", Offset = "0x5EA10F0", VA = "0x185EA22F0")]
		public MutableOverridableObscuredFloat(bool PGGKNKGAGIL, ObscuredFloat GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5EA21C0", Offset = "0x5EA0FC0", VA = "0x185EA21C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5EA20C0", Offset = "0x5EA0EC0", VA = "0x185EA20C0", Slot = "20")]
		public override void NFGDCGKAEAG(byte[] FLJECEJDFMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1FF0", Offset = "0x5EA0DF0", VA = "0x185EA1FF0", Slot = "19")]
		public override void BPJLIMDIDDK(BEKKEFKJHMJ PKLDEJDLNDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1F00", Offset = "0x5EA0D00", VA = "0x185EA1F00", Slot = "18")]
		public override BEKKEFKJHMJ BLJAODCPACP()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, NAJHNMKAGBK>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1200", Offset = "0x5EA0000", VA = "0x185EA1200")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1E90", Offset = "0x5EA0C90", VA = "0x185EA1E90")]
		public MutableOverridableObscuredBool(bool PGGKNKGAGIL, ObscuredBool GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1DC0", Offset = "0x5EA0BC0", VA = "0x185EA1DC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1CC0", Offset = "0x5EA0AC0", VA = "0x185EA1CC0", Slot = "20")]
		public override void NFGDCGKAEAG(byte[] FLJECEJDFMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1C00", Offset = "0x5EA0A00", VA = "0x185EA1C00", Slot = "19")]
		public override void BPJLIMDIDDK(NAJHNMKAGBK PKLDEJDLNDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1B20", Offset = "0x5EA0920", VA = "0x185EA1B20", Slot = "18")]
		public override NAJHNMKAGBK BLJAODCPACP()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, global::KMODLEBFCBH<ObscuredBool>, global::NGBGPAFAGGM<ObscuredBool>, global::MGCBLKJNMGL<ObscuredBool>, HPLMEPBNFMC
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7426F0", Offset = "0x7414F0", VA = "0x1807426F0", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x84DD30", Offset = "0x84CB30", VA = "0x18084DD30", Slot = "22")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1200", Offset = "0x5EA0000", VA = "0x185EA1200")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1180", Offset = "0x5E9FF80", VA = "0x185EA1180")]
		public void EMAGKKABFEF(MutableOverridableDefaultableObscuredBool MCLIMJFDMCF)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, OPPDNKHODGA> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x31660C0", Offset = "0x3164EC0", VA = "0x1831660C0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x31661A0", Offset = "0x3164FA0", VA = "0x1831661A0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x25A53E0", Offset = "0x25A41E0", VA = "0x1825A53E0")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3166090", Offset = "0x3164E90", VA = "0x183166090")]
		public SerializedMutableOverridableObscuredEnum(TObsEnum GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3166060", Offset = "0x3164E60", VA = "0x183166060")]
		public SerializedMutableOverridableObscuredEnum(bool PGGKNKGAGIL, TObsEnum GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3165D40", Offset = "0x3164B40", VA = "0x183165D40", Slot = "18")]
		public sealed override OPPDNKHODGA BLJAODCPACP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3165DF0", Offset = "0x3164BF0", VA = "0x183165DF0", Slot = "19")]
		public sealed override void BPJLIMDIDDK(OPPDNKHODGA PKLDEJDLNDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3165F60", Offset = "0x3164D60", VA = "0x183165F60", Slot = "20")]
		public sealed override void NFGDCGKAEAG(byte[] FLJECEJDFMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3165F00", Offset = "0x3164D00", VA = "0x183165F00", Slot = "17")]
		public sealed override void FBGINNLGAJA()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, DEHIFKCCALA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5EA1A50", Offset = "0x5EA0850", VA = "0x185EA1A50", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x5EA1A90", Offset = "0x5EA0890", VA = "0x185EA1A90", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1960", Offset = "0x5EA0760", VA = "0x185EA1960")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5EA19F0", Offset = "0x5EA07F0", VA = "0x185EA19F0")]
		public MutableOverridableListObscuredString(bool PGGKNKGAGIL, List<ObscuredString> GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5EA18C0", Offset = "0x5EA06C0", VA = "0x185EA18C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1750", Offset = "0x5EA0550", VA = "0x185EA1750", Slot = "17")]
		public override void FBGINNLGAJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5EA17C0", Offset = "0x5EA05C0", VA = "0x185EA17C0", Slot = "20")]
		public override void NFGDCGKAEAG(byte[] FLJECEJDFMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1430", Offset = "0x5EA0230", VA = "0x185EA1430", Slot = "19")]
		public override void BPJLIMDIDDK(DEHIFKCCALA PKLDEJDLNDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1270", Offset = "0x5EA0070", VA = "0x185EA1270", Slot = "18")]
		public override DEHIFKCCALA BLJAODCPACP()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : global::MGCBLKJNMGL<Vector3>, HPLMEPBNFMC
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
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x807770", Offset = "0x806570", VA = "0x180807770", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5EA29E0", Offset = "0x5EA17E0", VA = "0x185EA29E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x695E00", Offset = "0x694C00", VA = "0x180695E00", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5EA29C0", Offset = "0x5EA17C0", VA = "0x185EA29C0")]
		public OverridableVector3(Vector3 GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2920", Offset = "0x5EA1720", VA = "0x185EA2920", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2900", Offset = "0x5EA1700", VA = "0x185EA2900")]
		public static OverridableVector3 KPOCFOKDNEC(Vector3 FIHIOAOIPNG)
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
