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
public interface EKNPBACLJGI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MHGCOACHIEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object GOOFELEIOPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FEEJPCDIPMC<T> : EKNPBACLJGI
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T EEMLDMGPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BGNLLHAHEMI<T> : FEEJPCDIPMC<T>, EKNPBACLJGI
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool MHGCOACHIEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T EEMLDMGPOLA
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
public interface LBDHFLIBKDK<T> : BGNLLHAHEMI<T>, FEEJPCDIPMC<T>, EKNPBACLJGI
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool BOGCLGMDLAJ
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
	public struct OverridableInt : FEEJPCDIPMC<int>, EKNPBACLJGI
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
			[Cpp2IlInjected.Address(RVA = "0xA4D510", Offset = "0xA4C910", VA = "0x180A4D510", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6D9D4E0", Offset = "0x6D9C8E0", VA = "0x186D9D4E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x27EB090", Offset = "0x27EA490", VA = "0x1827EB090", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6D9D440", Offset = "0x6D9C840", VA = "0x186D9D440", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : FEEJPCDIPMC<string>, EKNPBACLJGI
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
			[Cpp2IlInjected.Address(RVA = "0xA4D510", Offset = "0xA4C910", VA = "0x180A4D510", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x92A850", Offset = "0x929C50", VA = "0x18092A850", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x92A850", Offset = "0x929C50", VA = "0x18092A850", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6D9D530", Offset = "0x6D9C930", VA = "0x186D9D530", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : BGNLLHAHEMI<InnerType>, FEEJPCDIPMC<InnerType>, EKNPBACLJGI where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool MHGCOACHIEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType EEMLDMGPOLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object GOOFELEIOPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x23C7A00", Offset = "0x23C6E00", VA = "0x1823C7A00", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4893EE0", Offset = "0x48932E0", VA = "0x184893EE0")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4893F10", Offset = "0x4893310", VA = "0x184893F10")]
		public MutableOverridableBase(bool KIJIJLEOPAL, [NotNull] InnerType EEPLCHCGAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4893490", Offset = "0x4892890", VA = "0x184893490", Slot = "15")]
		public void KMBJCNLBAEE(FEEJPCDIPMC<InnerType> OEPHNJIEIHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4893CD0", Offset = "0x48930D0", VA = "0x184893CD0", Slot = "16")]
		public void OOIHJHLMILI(FEEJPCDIPMC<InnerType> KNLMODPGFOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4893E40", Offset = "0x4893240", VA = "0x184893E40", Slot = "17")]
		public virtual void PGLAGHNEHAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType BCPKHAMPIGG();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void ABNCCGBILIM(ProtobufType IOLEPLKAOCL);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void LHMFEBNCJMI(byte[] OEAJBFNGFLL);
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
			[Cpp2IlInjected.Address(RVA = "0x946390", Offset = "0x945790", VA = "0x180946390", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x9463A0", Offset = "0x9457A0", VA = "0x1809463A0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x9463B0", Offset = "0x9457B0", VA = "0x1809463B0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3B9D470", Offset = "0x3B9C870", VA = "0x183B9D470")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4234F10", Offset = "0x4234310", VA = "0x184234F10")]
		public SerializedMutableOverridableBase(bool KIJIJLEOPAL, InnerType EEPLCHCGAIN)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, FGOLBLGCGPA>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6D9D370", Offset = "0x6D9C770", VA = "0x186D9D370")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6D9D3D0", Offset = "0x6D9C7D0", VA = "0x186D9D3D0")]
		public MutableOverridableObscuredInt(bool KIJIJLEOPAL, ObscuredInt EEPLCHCGAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6D9D2A0", Offset = "0x6D9C6A0", VA = "0x186D9D2A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6D9D1D0", Offset = "0x6D9C5D0", VA = "0x186D9D1D0", Slot = "20")]
		public override void LHMFEBNCJMI(byte[] OEAJBFNGFLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6D9D040", Offset = "0x6D9C440", VA = "0x186D9D040", Slot = "19")]
		public override void ABNCCGBILIM(FGOLBLGCGPA IOLEPLKAOCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6D9D0F0", Offset = "0x6D9C4F0", VA = "0x186D9D0F0", Slot = "18")]
		public override FGOLBLGCGPA BCPKHAMPIGG()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, NKEJMFEEIAL>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6D9CF70", Offset = "0x6D9C370", VA = "0x186D9CF70")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6D9CFD0", Offset = "0x6D9C3D0", VA = "0x186D9CFD0")]
		public MutableOverridableObscuredFloat(bool KIJIJLEOPAL, ObscuredFloat EEPLCHCGAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6D9CEA0", Offset = "0x6D9C2A0", VA = "0x186D9CEA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6D9CDD0", Offset = "0x6D9C1D0", VA = "0x186D9CDD0", Slot = "20")]
		public override void LHMFEBNCJMI(byte[] OEAJBFNGFLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6D9CC20", Offset = "0x6D9C020", VA = "0x186D9CC20", Slot = "19")]
		public override void ABNCCGBILIM(NKEJMFEEIAL IOLEPLKAOCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6D9CCE0", Offset = "0x6D9C0E0", VA = "0x186D9CCE0", Slot = "18")]
		public override NKEJMFEEIAL BCPKHAMPIGG()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, MDFIIFICCLE>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6D9BE50", Offset = "0x6D9B250", VA = "0x186D9BE50")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6D9CBB0", Offset = "0x6D9BFB0", VA = "0x186D9CBB0")]
		public MutableOverridableObscuredBool(bool KIJIJLEOPAL, ObscuredBool EEPLCHCGAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6D9CAE0", Offset = "0x6D9BEE0", VA = "0x186D9CAE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6D9C980", Offset = "0x6D9BD80", VA = "0x186D9C980", Slot = "20")]
		public override void LHMFEBNCJMI(byte[] OEAJBFNGFLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6D9C7D0", Offset = "0x6D9BBD0", VA = "0x186D9C7D0", Slot = "19")]
		public override void ABNCCGBILIM(MDFIIFICCLE IOLEPLKAOCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6D9C890", Offset = "0x6D9BC90", VA = "0x186D9C890", Slot = "18")]
		public override MDFIIFICCLE BCPKHAMPIGG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6D9CA50", Offset = "0x6D9BE50", VA = "0x186D9CA50", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, LBDHFLIBKDK<ObscuredBool>, BGNLLHAHEMI<ObscuredBool>, FEEJPCDIPMC<ObscuredBool>, EKNPBACLJGI
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8B2C50", Offset = "0x8B2050", VA = "0x1808B2C50", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8B2C10", Offset = "0x8B2010", VA = "0x1808B2C10", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6D9BE50", Offset = "0x6D9B250", VA = "0x186D9BE50")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6D9BDD0", Offset = "0x6D9B1D0", VA = "0x186D9BDD0")]
		public void KMBJCNLBAEE(MutableOverridableDefaultableObscuredBool KNLMODPGFOA)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, FGOLBLGCGPA> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x4D3C4D0", Offset = "0x4D3B8D0", VA = "0x184D3C4D0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x4D3C670", Offset = "0x4D3BA70", VA = "0x184D3C670", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x426C960", Offset = "0x426BD60", VA = "0x18426C960")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4D3C490", Offset = "0x4D3B890", VA = "0x184D3C490")]
		public SerializedMutableOverridableObscuredEnum(bool KIJIJLEOPAL, TObsEnum EEPLCHCGAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4D3C240", Offset = "0x4D3B640", VA = "0x184D3C240", Slot = "18")]
		public sealed override FGOLBLGCGPA BCPKHAMPIGG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4D3C140", Offset = "0x4D3B540", VA = "0x184D3C140", Slot = "19")]
		public sealed override void ABNCCGBILIM(FGOLBLGCGPA IOLEPLKAOCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4D3C330", Offset = "0x4D3B730", VA = "0x184D3C330", Slot = "20")]
		public sealed override void LHMFEBNCJMI(byte[] OEAJBFNGFLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4D3C410", Offset = "0x4D3B810", VA = "0x184D3C410", Slot = "17")]
		public sealed override void PGLAGHNEHAA()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, BBFDJBONFGH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6D9C700", Offset = "0x6D9BB00", VA = "0x186D9C700", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6D9C740", Offset = "0x6D9BB40", VA = "0x186D9C740", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6D9C660", Offset = "0x6D9BA60", VA = "0x186D9C660")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6D9C600", Offset = "0x6D9BA00", VA = "0x186D9C600")]
		public MutableOverridableListObscuredString(bool KIJIJLEOPAL, List<ObscuredString> EEPLCHCGAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6D9C560", Offset = "0x6D9B960", VA = "0x186D9C560", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6D9C4D0", Offset = "0x6D9B8D0", VA = "0x186D9C4D0", Slot = "17")]
		public override void PGLAGHNEHAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6D9C400", Offset = "0x6D9B800", VA = "0x186D9C400", Slot = "20")]
		public override void LHMFEBNCJMI(byte[] OEAJBFNGFLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6D9BEC0", Offset = "0x6D9B2C0", VA = "0x186D9BEC0", Slot = "19")]
		public override void ABNCCGBILIM(BBFDJBONFGH IOLEPLKAOCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6D9C220", Offset = "0x6D9B620", VA = "0x186D9C220", Slot = "18")]
		public override BBFDJBONFGH BCPKHAMPIGG()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : FEEJPCDIPMC<Vector3>, EKNPBACLJGI
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
			[Cpp2IlInjected.Address(RVA = "0xA4D510", Offset = "0xA4C910", VA = "0x180A4D510", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6D9D660", Offset = "0x6D9CA60", VA = "0x186D9D660", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x456C890", Offset = "0x456BC90", VA = "0x18456C890", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x49DC4E0", Offset = "0x49DB8E0", VA = "0x1849DC4E0")]
		public OverridableVector3(Vector3 EEPLCHCGAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4FD7390", Offset = "0x4FD6790", VA = "0x184FD7390")]
		public OverridableVector3(bool KIJIJLEOPAL, Vector3 EEPLCHCGAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6D9D5C0", Offset = "0x6D9C9C0", VA = "0x186D9D5C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6D9D5A0", Offset = "0x6D9C9A0", VA = "0x186D9D5A0")]
		public static OverridableVector3 EGFECENGKHG(Vector3 OAKJBMEGCLP)
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
