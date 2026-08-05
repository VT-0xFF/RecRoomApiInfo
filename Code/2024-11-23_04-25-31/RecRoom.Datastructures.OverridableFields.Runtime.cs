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
public interface HHJNMKJALJD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool HAEPFMGGKEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object NIKEBNEHCJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FCECNCIBAEP<T> : HHJNMKJALJD
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T IPHIEALFCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BABDCDEAJPB<T> : FCECNCIBAEP<T>, HHJNMKJALJD
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool HAEPFMGGKEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T IPHIEALFCML
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
public interface NFHBJKMGHHP<T> : BABDCDEAJPB<T>, FCECNCIBAEP<T>, HHJNMKJALJD
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool PMINIEMFLHP
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
	public struct OverridableInt : FCECNCIBAEP<int>, HHJNMKJALJD
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
			[Cpp2IlInjected.Address(RVA = "0xAA3AA0", Offset = "0xAA24A0", VA = "0x180AA3AA0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6DBB800", Offset = "0x6DBA200", VA = "0x186DBB800", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x286D5C0", Offset = "0x286BFC0", VA = "0x18286D5C0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6DBB760", Offset = "0x6DBA160", VA = "0x186DBB760", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : FCECNCIBAEP<string>, HHJNMKJALJD
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
			[Cpp2IlInjected.Address(RVA = "0xAA3AA0", Offset = "0xAA24A0", VA = "0x180AA3AA0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9577A0", Offset = "0x9561A0", VA = "0x1809577A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9577A0", Offset = "0x9561A0", VA = "0x1809577A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6DBB850", Offset = "0x6DBA250", VA = "0x186DBB850", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : BABDCDEAJPB<InnerType>, FCECNCIBAEP<InnerType>, HHJNMKJALJD where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool HAEPFMGGKEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType IPHIEALFCML
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object NIKEBNEHCJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x243A590", Offset = "0x2438F90", VA = "0x18243A590", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4906CF0", Offset = "0x49056F0", VA = "0x184906CF0")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4906D20", Offset = "0x4905720", VA = "0x184906D20")]
		public MutableOverridableBase(bool DHPJHIAHOAO, [NotNull] InnerType PKCLPFEIPFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4906B50", Offset = "0x4905550", VA = "0x184906B50", Slot = "15")]
		public void MKNNOIPPHFM(FCECNCIBAEP<InnerType> CFANALLNGDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4906780", Offset = "0x4905180", VA = "0x184906780", Slot = "16")]
		public void DEIPJDPOBED(FCECNCIBAEP<InnerType> GDOGPMPJPOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4906840", Offset = "0x4905240", VA = "0x184906840", Slot = "17")]
		public virtual void ENPPBKGKMKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType GMCNGBHHPBA();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void JPHBOODKIHI(ProtobufType IAFEBONJPKB);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void FFDGDBMKMOL(byte[] BBLFAJNADMO);
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
			[Cpp2IlInjected.Address(RVA = "0x930140", Offset = "0x92EB40", VA = "0x180930140", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x9A2C60", Offset = "0x9A1660", VA = "0x1809A2C60", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x9A2C70", Offset = "0x9A1670", VA = "0x1809A2C70", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3B8EA60", Offset = "0x3B8D460", VA = "0x183B8EA60")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x468A410", Offset = "0x4688E10", VA = "0x18468A410")]
		public SerializedMutableOverridableBase(bool DHPJHIAHOAO, InnerType PKCLPFEIPFH)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, KJDHGBKKDFI>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6DBB690", Offset = "0x6DBA090", VA = "0x186DBB690")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6DBB6F0", Offset = "0x6DBA0F0", VA = "0x186DBB6F0")]
		public MutableOverridableObscuredInt(bool DHPJHIAHOAO, ObscuredInt PKCLPFEIPFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6DBB5C0", Offset = "0x6DB9FC0", VA = "0x186DBB5C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6DBB360", Offset = "0x6DB9D60", VA = "0x186DBB360", Slot = "20")]
		public override void FFDGDBMKMOL(byte[] BBLFAJNADMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6DBB510", Offset = "0x6DB9F10", VA = "0x186DBB510", Slot = "19")]
		public override void JPHBOODKIHI(KJDHGBKKDFI IAFEBONJPKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6DBB430", Offset = "0x6DB9E30", VA = "0x186DBB430", Slot = "18")]
		public override KJDHGBKKDFI GMCNGBHHPBA()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, NOHOOHGELBB>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6DBB290", Offset = "0x6DB9C90", VA = "0x186DBB290")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6DBB2F0", Offset = "0x6DB9CF0", VA = "0x186DBB2F0")]
		public MutableOverridableObscuredFloat(bool DHPJHIAHOAO, ObscuredFloat PKCLPFEIPFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6DBB1C0", Offset = "0x6DB9BC0", VA = "0x186DBB1C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6DBAF40", Offset = "0x6DB9940", VA = "0x186DBAF40", Slot = "20")]
		public override void FFDGDBMKMOL(byte[] BBLFAJNADMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6DBB100", Offset = "0x6DB9B00", VA = "0x186DBB100", Slot = "19")]
		public override void JPHBOODKIHI(NOHOOHGELBB IAFEBONJPKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6DBB010", Offset = "0x6DB9A10", VA = "0x186DBB010", Slot = "18")]
		public override NOHOOHGELBB GMCNGBHHPBA()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, GKMFGBOLGPD>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6DBA160", Offset = "0x6DB8B60", VA = "0x186DBA160")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6DBAED0", Offset = "0x6DB98D0", VA = "0x186DBAED0")]
		public MutableOverridableObscuredBool(bool DHPJHIAHOAO, ObscuredBool PKCLPFEIPFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6DBAE00", Offset = "0x6DB9800", VA = "0x186DBAE00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6DBAAF0", Offset = "0x6DB94F0", VA = "0x186DBAAF0", Slot = "20")]
		public override void FFDGDBMKMOL(byte[] BBLFAJNADMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6DBACB0", Offset = "0x6DB96B0", VA = "0x186DBACB0", Slot = "19")]
		public override void JPHBOODKIHI(GKMFGBOLGPD IAFEBONJPKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6DBABC0", Offset = "0x6DB95C0", VA = "0x186DBABC0", Slot = "18")]
		public override GKMFGBOLGPD GMCNGBHHPBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6DBAD70", Offset = "0x6DB9770", VA = "0x186DBAD70", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, NFHBJKMGHHP<ObscuredBool>, BABDCDEAJPB<ObscuredBool>, FCECNCIBAEP<ObscuredBool>, HHJNMKJALJD
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8B0220", Offset = "0x8AEC20", VA = "0x1808B0220", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8B0150", Offset = "0x8AEB50", VA = "0x1808B0150", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6DBA160", Offset = "0x6DB8B60", VA = "0x186DBA160")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6DBA0E0", Offset = "0x6DB8AE0", VA = "0x186DBA0E0")]
		public void MKNNOIPPHFM(MutableOverridableDefaultableObscuredBool GDOGPMPJPOO)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, KJDHGBKKDFI> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x4D82940", Offset = "0x4D81340", VA = "0x184D82940", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x4D82AE0", Offset = "0x4D814E0", VA = "0x184D82AE0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x426C0B0", Offset = "0x426AAB0", VA = "0x18426C0B0")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4D82900", Offset = "0x4D81300", VA = "0x184D82900")]
		public SerializedMutableOverridableObscuredEnum(bool DHPJHIAHOAO, TObsEnum PKCLPFEIPFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4D82710", Offset = "0x4D81110", VA = "0x184D82710", Slot = "18")]
		public sealed override KJDHGBKKDFI GMCNGBHHPBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4D82800", Offset = "0x4D81200", VA = "0x184D82800", Slot = "19")]
		public sealed override void JPHBOODKIHI(KJDHGBKKDFI IAFEBONJPKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4D82630", Offset = "0x4D81030", VA = "0x184D82630", Slot = "20")]
		public sealed override void FFDGDBMKMOL(byte[] BBLFAJNADMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4D825B0", Offset = "0x4D80FB0", VA = "0x184D825B0", Slot = "17")]
		public sealed override void ENPPBKGKMKJ()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, GNIFABAMLMG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6DBAA20", Offset = "0x6DB9420", VA = "0x186DBAA20", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6DBAA60", Offset = "0x6DB9460", VA = "0x186DBAA60", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6DBA980", Offset = "0x6DB9380", VA = "0x186DBA980")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6DBA920", Offset = "0x6DB9320", VA = "0x186DBA920")]
		public MutableOverridableListObscuredString(bool DHPJHIAHOAO, List<ObscuredString> PKCLPFEIPFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6DBA880", Offset = "0x6DB9280", VA = "0x186DBA880", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6DBA1D0", Offset = "0x6DB8BD0", VA = "0x186DBA1D0", Slot = "17")]
		public override void ENPPBKGKMKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6DBA260", Offset = "0x6DB8C60", VA = "0x186DBA260", Slot = "20")]
		public override void FFDGDBMKMOL(byte[] BBLFAJNADMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6DBA510", Offset = "0x6DB8F10", VA = "0x186DBA510", Slot = "19")]
		public override void JPHBOODKIHI(GNIFABAMLMG IAFEBONJPKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6DBA330", Offset = "0x6DB8D30", VA = "0x186DBA330", Slot = "18")]
		public override GNIFABAMLMG GMCNGBHHPBA()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : FCECNCIBAEP<Vector3>, HHJNMKJALJD
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
			[Cpp2IlInjected.Address(RVA = "0xAA3AA0", Offset = "0xAA24A0", VA = "0x180AA3AA0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6DBB980", Offset = "0x6DBA380", VA = "0x186DBB980", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x464A400", Offset = "0x4648E00", VA = "0x18464A400", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4A1C300", Offset = "0x4A1AD00", VA = "0x184A1C300")]
		public OverridableVector3(Vector3 PKCLPFEIPFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x501ACC0", Offset = "0x50196C0", VA = "0x18501ACC0")]
		public OverridableVector3(bool DHPJHIAHOAO, Vector3 PKCLPFEIPFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6DBB8E0", Offset = "0x6DBA2E0", VA = "0x186DBB8E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6DBB8C0", Offset = "0x6DBA2C0", VA = "0x186DBB8C0")]
		public static OverridableVector3 OLKJPEKNNFN(Vector3 JBKDPHAINMM)
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
