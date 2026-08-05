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
public interface FGMHKGEFIPO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MMNHGDGDGJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object KBKEKDCCKLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DFJGLPPIADF<T> : FGMHKGEFIPO
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T FAGODIAEODP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface JBEMNGIEHME<T> : DFJGLPPIADF<T>, FGMHKGEFIPO
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool MMNHGDGDGJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T FAGODIAEODP
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
public interface MAAIOANLFAI<T> : JBEMNGIEHME<T>, DFJGLPPIADF<T>, FGMHKGEFIPO
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool BGHOPJKLNOC
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
	public struct OverridableInt : DFJGLPPIADF<int>, FGMHKGEFIPO
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
			[Cpp2IlInjected.Address(RVA = "0x10B0470", Offset = "0x10AEA70", VA = "0x1810B0470", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x841F350", Offset = "0x841D950", VA = "0x18841F350", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x302EA20", Offset = "0x302D020", VA = "0x18302EA20", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x841F2B0", Offset = "0x841D8B0", VA = "0x18841F2B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : DFJGLPPIADF<string>, FGMHKGEFIPO
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
			[Cpp2IlInjected.Address(RVA = "0x10B0470", Offset = "0x10AEA70", VA = "0x1810B0470", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xB41580", Offset = "0xB3FB80", VA = "0x180B41580", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xB41580", Offset = "0xB3FB80", VA = "0x180B41580", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x841F3A0", Offset = "0x841D9A0", VA = "0x18841F3A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : JBEMNGIEHME<InnerType>, DFJGLPPIADF<InnerType>, FGMHKGEFIPO where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool MMNHGDGDGJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType FAGODIAEODP
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object KBKEKDCCKLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2D20620", Offset = "0x2D1EC20", VA = "0x182D20620", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x59C0F70", Offset = "0x59BF570", VA = "0x1859C0F70")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x59C0FA0", Offset = "0x59BF5A0", VA = "0x1859C0FA0")]
		public MutableOverridableBase(bool LIIFGNOLJKD, [NotNull] InnerType FKMNCAKIOFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x59C0D70", Offset = "0x59BF370", VA = "0x1859C0D70", Slot = "15")]
		public void JFFNDLKEBBJ(DFJGLPPIADF<InnerType> NMDPPNGCJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x59C0660", Offset = "0x59BEC60", VA = "0x1859C0660", Slot = "16")]
		public void CCEONOOKKGH(DFJGLPPIADF<InnerType> IBCMCOKAJEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x59C0A50", Offset = "0x59BF050", VA = "0x1859C0A50", Slot = "17")]
		public virtual void IMGLACMMFNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType IDKDEINKDAK();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void IMKKJDGIMPD(ProtobufType MALOPIGGMEG);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void MCDNAEIBIFO(byte[] FOJOFGLLOMP);
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
			[Cpp2IlInjected.Address(RVA = "0xB72630", Offset = "0xB70C30", VA = "0x180B72630", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xB72650", Offset = "0xB70C50", VA = "0x180B72650", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xF7DEA0", Offset = "0xF7C4A0", VA = "0x180F7DEA0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4A126E0", Offset = "0x4A10CE0", VA = "0x184A126E0")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5C6BD40", Offset = "0x5C6A340", VA = "0x185C6BD40")]
		public SerializedMutableOverridableBase(bool LIIFGNOLJKD, InnerType FKMNCAKIOFK)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, OPAKHIJEJJJ>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x841F1E0", Offset = "0x841D7E0", VA = "0x18841F1E0")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x841F240", Offset = "0x841D840", VA = "0x18841F240")]
		public MutableOverridableObscuredInt(bool LIIFGNOLJKD, ObscuredInt FKMNCAKIOFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x841F110", Offset = "0x841D710", VA = "0x18841F110", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x841F030", Offset = "0x841D630", VA = "0x18841F030", Slot = "20")]
		public override void MCDNAEIBIFO(byte[] FOJOFGLLOMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x841EF80", Offset = "0x841D580", VA = "0x18841EF80", Slot = "19")]
		public override void IMKKJDGIMPD(OPAKHIJEJJJ MALOPIGGMEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x841EEA0", Offset = "0x841D4A0", VA = "0x18841EEA0", Slot = "18")]
		public override OPAKHIJEJJJ IDKDEINKDAK()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, NEHHPLIACOF>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x841EDD0", Offset = "0x841D3D0", VA = "0x18841EDD0")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x841EE30", Offset = "0x841D430", VA = "0x18841EE30")]
		public MutableOverridableObscuredFloat(bool LIIFGNOLJKD, ObscuredFloat FKMNCAKIOFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x841ED00", Offset = "0x841D300", VA = "0x18841ED00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x841EC20", Offset = "0x841D220", VA = "0x18841EC20", Slot = "20")]
		public override void MCDNAEIBIFO(byte[] FOJOFGLLOMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x841EB60", Offset = "0x841D160", VA = "0x18841EB60", Slot = "19")]
		public override void IMKKJDGIMPD(NEHHPLIACOF MALOPIGGMEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x841EA70", Offset = "0x841D070", VA = "0x18841EA70", Slot = "18")]
		public override NEHHPLIACOF IDKDEINKDAK()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, BMLEHHHJHBL>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x841DC90", Offset = "0x841C290", VA = "0x18841DC90")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x841EA00", Offset = "0x841D000", VA = "0x18841EA00")]
		public MutableOverridableObscuredBool(bool LIIFGNOLJKD, ObscuredBool FKMNCAKIOFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x841E930", Offset = "0x841CF30", VA = "0x18841E930", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x841E7C0", Offset = "0x841CDC0", VA = "0x18841E7C0", Slot = "20")]
		public override void MCDNAEIBIFO(byte[] FOJOFGLLOMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x841E700", Offset = "0x841CD00", VA = "0x18841E700", Slot = "19")]
		public override void IMKKJDGIMPD(BMLEHHHJHBL MALOPIGGMEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x841E610", Offset = "0x841CC10", VA = "0x18841E610", Slot = "18")]
		public override BMLEHHHJHBL IDKDEINKDAK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x841E8A0", Offset = "0x841CEA0", VA = "0x18841E8A0", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, MAAIOANLFAI<ObscuredBool>, JBEMNGIEHME<ObscuredBool>, DFJGLPPIADF<ObscuredBool>, FGMHKGEFIPO
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA95030", Offset = "0xA93630", VA = "0x180A95030", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA94FC0", Offset = "0xA935C0", VA = "0x180A94FC0", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x841DC90", Offset = "0x841C290", VA = "0x18841DC90")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x841DC10", Offset = "0x841C210", VA = "0x18841DC10")]
		public void JFFNDLKEBBJ(MutableOverridableDefaultableObscuredBool IBCMCOKAJEM)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, OPAKHIJEJJJ> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x5EBA120", Offset = "0x5EB8720", VA = "0x185EBA120", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x5EBA250", Offset = "0x5EB8850", VA = "0x185EBA250", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x52768C0", Offset = "0x5274EC0", VA = "0x1852768C0")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5EBA100", Offset = "0x5EB8700", VA = "0x185EBA100")]
		public SerializedMutableOverridableObscuredEnum(bool LIIFGNOLJKD, TObsEnum FKMNCAKIOFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5EB9DC0", Offset = "0x5EB83C0", VA = "0x185EB9DC0", Slot = "18")]
		public sealed override OPAKHIJEJJJ IDKDEINKDAK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5EB9F20", Offset = "0x5EB8520", VA = "0x185EB9F20", Slot = "19")]
		public sealed override void IMKKJDGIMPD(OPAKHIJEJJJ MALOPIGGMEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5EBA020", Offset = "0x5EB8620", VA = "0x185EBA020", Slot = "20")]
		public sealed override void MCDNAEIBIFO(byte[] FOJOFGLLOMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5EB9EB0", Offset = "0x5EB84B0", VA = "0x185EB9EB0", Slot = "17")]
		public sealed override void IMGLACMMFNI()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, LIJDLHFBPLE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x841E540", Offset = "0x841CB40", VA = "0x18841E540", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x841E580", Offset = "0x841CB80", VA = "0x18841E580", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x841E4A0", Offset = "0x841CAA0", VA = "0x18841E4A0")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x841E440", Offset = "0x841CA40", VA = "0x18841E440")]
		public MutableOverridableListObscuredString(bool LIIFGNOLJKD, List<ObscuredString> FKMNCAKIOFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x841E3A0", Offset = "0x841C9A0", VA = "0x18841E3A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x841DEE0", Offset = "0x841C4E0", VA = "0x18841DEE0", Slot = "17")]
		public override void IMGLACMMFNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x841E2C0", Offset = "0x841C8C0", VA = "0x18841E2C0", Slot = "20")]
		public override void MCDNAEIBIFO(byte[] FOJOFGLLOMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x841DF70", Offset = "0x841C570", VA = "0x18841DF70", Slot = "19")]
		public override void IMKKJDGIMPD(LIJDLHFBPLE MALOPIGGMEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x841DD00", Offset = "0x841C300", VA = "0x18841DD00", Slot = "18")]
		public override LIJDLHFBPLE IDKDEINKDAK()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : DFJGLPPIADF<Vector3>, FGMHKGEFIPO
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
			[Cpp2IlInjected.Address(RVA = "0x10B0470", Offset = "0x10AEA70", VA = "0x1810B0470", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x841F4D0", Offset = "0x841DAD0", VA = "0x18841F4D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAE8D20", Offset = "0xAE7320", VA = "0x180AE8D20", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5AFCAC0", Offset = "0x5AFB0C0", VA = "0x185AFCAC0")]
		public OverridableVector3(Vector3 FKMNCAKIOFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6207270", Offset = "0x6205870", VA = "0x186207270")]
		public OverridableVector3(bool LIIFGNOLJKD, Vector3 FKMNCAKIOFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x841F430", Offset = "0x841DA30", VA = "0x18841F430", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x841F410", Offset = "0x841DA10", VA = "0x18841F410")]
		public static OverridableVector3 HPNBGLLBBBG(Vector3 PGNMBFKGLAH)
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
