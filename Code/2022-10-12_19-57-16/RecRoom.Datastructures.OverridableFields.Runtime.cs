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
public interface GHFLNLLKPCE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool HDLECFKEHJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object JFANEBLCHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HFEEKLKHJDM<T> : GHFLNLLKPCE
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T FHONEBOCBPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BDCMMKCGAGK<T> : global::HFEEKLKHJDM<T>, GHFLNLLKPCE
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool HDLECFKEHJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T FHONEBOCBPE
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
public interface BEKLLBIIBDM<T> : global::BDCMMKCGAGK<T>, global::HFEEKLKHJDM<T>, GHFLNLLKPCE
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool BHKHKGGOOBD
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
	public struct OverridableInt : global::HFEEKLKHJDM<int>, GHFLNLLKPCE
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
			[Cpp2IlInjected.Address(RVA = "0x8CADB0", Offset = "0x8C9DB0", VA = "0x1808CADB0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5E27C60", Offset = "0x5E26C60", VA = "0x185E27C60", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8A3600", Offset = "0x8A2600", VA = "0x1808A3600", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5E27BC0", Offset = "0x5E26BC0", VA = "0x185E27BC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : global::HFEEKLKHJDM<string>, GHFLNLLKPCE
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
			[Cpp2IlInjected.Address(RVA = "0x8CADB0", Offset = "0x8C9DB0", VA = "0x1808CADB0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6A0B00", Offset = "0x69FB00", VA = "0x1806A0B00", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6A0B00", Offset = "0x69FB00", VA = "0x1806A0B00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5E27CB0", Offset = "0x5E26CB0", VA = "0x185E27CB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : global::BDCMMKCGAGK<InnerType>, global::HFEEKLKHJDM<InnerType>, GHFLNLLKPCE where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool HDLECFKEHJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType FHONEBOCBPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object JFANEBLCHAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2361590", Offset = "0x2360590", VA = "0x182361590", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2361300", Offset = "0x2360300", VA = "0x182361300")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x23613C0", Offset = "0x23603C0", VA = "0x1823613C0")]
		public MutableOverridableBase(bool DDFNJEFLLHO, [NotNull] InnerType CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2360FC0", Offset = "0x235FFC0", VA = "0x182360FC0", Slot = "15")]
		public void NLIONKHOHDJ(global::HFEEKLKHJDM<InnerType> NADIPGLPIOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2360AF0", Offset = "0x235FAF0", VA = "0x182360AF0", Slot = "16")]
		public void AECOPHMDBCG(global::HFEEKLKHJDM<InnerType> IIKMMJKCGDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2361090", Offset = "0x2360090", VA = "0x182361090", Slot = "17")]
		public virtual void PKLFPAMOGPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType LOPDKNPMGDK();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void OHMFMOMIGEK(ProtobufType MDHBBFHLKKH);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void EBJLJHGHDPB(byte[] FBOPNKEGFCC);
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
			[Cpp2IlInjected.Address(RVA = "0x64E250", Offset = "0x64D250", VA = "0x18064E250", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x64E270", Offset = "0x64D270", VA = "0x18064E270", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1729EC0", Offset = "0x1728EC0", VA = "0x181729EC0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x173E7A0", Offset = "0x173D7A0", VA = "0x18173E7A0")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x25A2AB0", Offset = "0x25A1AB0", VA = "0x1825A2AB0")]
		public SerializedMutableOverridableBase(bool DDFNJEFLLHO, InnerType CCIMHDCKHOF)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, HGEKJIEBJKH>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5E27B60", Offset = "0x5E26B60", VA = "0x185E27B60")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5E27AF0", Offset = "0x5E26AF0", VA = "0x185E27AF0")]
		public MutableOverridableObscuredInt(bool DDFNJEFLLHO, ObscuredInt CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5E27A20", Offset = "0x5E26A20", VA = "0x185E27A20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5E27780", Offset = "0x5E26780", VA = "0x185E27780", Slot = "20")]
		public override void EBJLJHGHDPB(byte[] FBOPNKEGFCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5E27960", Offset = "0x5E26960", VA = "0x185E27960", Slot = "19")]
		public override void OHMFMOMIGEK(HGEKJIEBJKH MDHBBFHLKKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5E27880", Offset = "0x5E26880", VA = "0x185E27880", Slot = "18")]
		public override HGEKJIEBJKH LOPDKNPMGDK()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, CLFJHIPIMKJ>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5E276B0", Offset = "0x5E266B0", VA = "0x185E276B0")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5E27710", Offset = "0x5E26710", VA = "0x185E27710")]
		public MutableOverridableObscuredFloat(bool DDFNJEFLLHO, ObscuredFloat CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5E275E0", Offset = "0x5E265E0", VA = "0x185E275E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5E27320", Offset = "0x5E26320", VA = "0x185E27320", Slot = "20")]
		public override void EBJLJHGHDPB(byte[] FBOPNKEGFCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5E27510", Offset = "0x5E26510", VA = "0x185E27510", Slot = "19")]
		public override void OHMFMOMIGEK(CLFJHIPIMKJ MDHBBFHLKKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5E27420", Offset = "0x5E26420", VA = "0x185E27420", Slot = "18")]
		public override CLFJHIPIMKJ LOPDKNPMGDK()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, ADMGANPPPGO>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5E26620", Offset = "0x5E25620", VA = "0x185E26620")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5E272B0", Offset = "0x5E262B0", VA = "0x185E272B0")]
		public MutableOverridableObscuredBool(bool DDFNJEFLLHO, ObscuredBool CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5E271E0", Offset = "0x5E261E0", VA = "0x185E271E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5E26F40", Offset = "0x5E25F40", VA = "0x185E26F40", Slot = "20")]
		public override void EBJLJHGHDPB(byte[] FBOPNKEGFCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5E27120", Offset = "0x5E26120", VA = "0x185E27120", Slot = "19")]
		public override void OHMFMOMIGEK(ADMGANPPPGO MDHBBFHLKKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5E27040", Offset = "0x5E26040", VA = "0x185E27040", Slot = "18")]
		public override ADMGANPPPGO LOPDKNPMGDK()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, global::BEKLLBIIBDM<ObscuredBool>, global::BDCMMKCGAGK<ObscuredBool>, global::HFEEKLKHJDM<ObscuredBool>, GHFLNLLKPCE
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6653D0", Offset = "0x6643D0", VA = "0x1806653D0", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7711D0", Offset = "0x7701D0", VA = "0x1807711D0", Slot = "22")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5E26620", Offset = "0x5E25620", VA = "0x185E26620")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5E265A0", Offset = "0x5E255A0", VA = "0x185E265A0")]
		public void NLIONKHOHDJ(MutableOverridableDefaultableObscuredBool IIKMMJKCGDO)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, HGEKJIEBJKH> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x2F7D3D0", Offset = "0x2F7C3D0", VA = "0x182F7D3D0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x2F7D4B0", Offset = "0x2F7C4B0", VA = "0x182F7D4B0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x24FF4F0", Offset = "0x24FE4F0", VA = "0x1824FF4F0")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2F7D3A0", Offset = "0x2F7C3A0", VA = "0x182F7D3A0")]
		public SerializedMutableOverridableObscuredEnum(TObsEnum CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2D36920", Offset = "0x2D35920", VA = "0x182D36920")]
		public SerializedMutableOverridableObscuredEnum(bool DDFNJEFLLHO, TObsEnum CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2F7D180", Offset = "0x2F7C180", VA = "0x182F7D180", Slot = "18")]
		public sealed override HGEKJIEBJKH LOPDKNPMGDK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2F7D230", Offset = "0x2F7C230", VA = "0x182F7D230", Slot = "19")]
		public sealed override void OHMFMOMIGEK(HGEKJIEBJKH MDHBBFHLKKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2F7D080", Offset = "0x2F7C080", VA = "0x182F7D080", Slot = "20")]
		public sealed override void EBJLJHGHDPB(byte[] FBOPNKEGFCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2F7D340", Offset = "0x2F7C340", VA = "0x182F7D340", Slot = "17")]
		public sealed override void PKLFPAMOGPP()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, IDOOICDJCOI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5E26E70", Offset = "0x5E25E70", VA = "0x185E26E70", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x5E26EB0", Offset = "0x5E25EB0", VA = "0x185E26EB0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5E26D80", Offset = "0x5E25D80", VA = "0x185E26D80")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5E26E10", Offset = "0x5E25E10", VA = "0x185E26E10")]
		public MutableOverridableListObscuredString(bool DDFNJEFLLHO, List<ObscuredString> CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5E26CE0", Offset = "0x5E25CE0", VA = "0x185E26CE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5E26C70", Offset = "0x5E25C70", VA = "0x185E26C70", Slot = "17")]
		public override void PKLFPAMOGPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5E26690", Offset = "0x5E25690", VA = "0x185E26690", Slot = "20")]
		public override void EBJLJHGHDPB(byte[] FBOPNKEGFCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5E26950", Offset = "0x5E25950", VA = "0x185E26950", Slot = "19")]
		public override void OHMFMOMIGEK(IDOOICDJCOI MDHBBFHLKKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5E26790", Offset = "0x5E25790", VA = "0x185E26790", Slot = "18")]
		public override IDOOICDJCOI LOPDKNPMGDK()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : global::HFEEKLKHJDM<Vector3>, GHFLNLLKPCE
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
			[Cpp2IlInjected.Address(RVA = "0x8CADB0", Offset = "0x8C9DB0", VA = "0x1808CADB0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5E27E00", Offset = "0x5E26E00", VA = "0x185E27E00", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x1F7F8A0", Offset = "0x1F7E8A0", VA = "0x181F7F8A0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5E27DE0", Offset = "0x5E26DE0", VA = "0x185E27DE0")]
		public OverridableVector3(Vector3 CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5E27D40", Offset = "0x5E26D40", VA = "0x185E27D40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5E27D20", Offset = "0x5E26D20", VA = "0x185E27D20")]
		public static OverridableVector3 EDIIAGKPKGG(Vector3 OGAPHEEOKGM)
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
