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
public interface BHDFBGPBBLL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NDLKEHCHIJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object IOJGLCCLGOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LJMAANFHOEL<T> : BHDFBGPBBLL
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T NAJOFLHMBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface APLFLNLCFMO<T> : LJMAANFHOEL<T>, BHDFBGPBBLL
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool NDLKEHCHIJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T NAJOFLHMBPO
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
public interface NFODOCEFBFB<T> : APLFLNLCFMO<T>, LJMAANFHOEL<T>, BHDFBGPBBLL
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool KKLBHLKHPLN
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
	public struct OverridableInt : LJMAANFHOEL<int>, BHDFBGPBBLL
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
			[Cpp2IlInjected.Address(RVA = "0x1A3F700", Offset = "0x1A3EB00", VA = "0x181A3F700", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5F1F090", Offset = "0x5F1E490", VA = "0x185F1F090", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x21C5940", Offset = "0x21C4D40", VA = "0x1821C5940", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5F1EFF0", Offset = "0x5F1E3F0", VA = "0x185F1EFF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : LJMAANFHOEL<string>, BHDFBGPBBLL
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
			[Cpp2IlInjected.Address(RVA = "0x1A3F700", Offset = "0x1A3EB00", VA = "0x181A3F700", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8829F0", Offset = "0x881DF0", VA = "0x1808829F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8829F0", Offset = "0x881DF0", VA = "0x1808829F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5F1F0E0", Offset = "0x5F1E4E0", VA = "0x185F1F0E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : APLFLNLCFMO<InnerType>, LJMAANFHOEL<InnerType>, BHDFBGPBBLL where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool NDLKEHCHIJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType NAJOFLHMBPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object IOJGLCCLGOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x217EEE0", Offset = "0x217E2E0", VA = "0x18217EEE0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3DDD270", Offset = "0x3DDC670", VA = "0x183DDD270")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3DDD2A0", Offset = "0x3DDC6A0", VA = "0x183DDD2A0")]
		public MutableOverridableBase(bool MBOBIPBNHLD, [NotNull] InnerType FDFHGIHHGHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3DDCBD0", Offset = "0x3DDBFD0", VA = "0x183DDCBD0", Slot = "15")]
		public void KOAPJIPKLFK(LJMAANFHOEL<InnerType> NEHCLJEAPPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3DDD070", Offset = "0x3DDC470", VA = "0x183DDD070", Slot = "16")]
		public void LEIGIPOJOGD(LJMAANFHOEL<InnerType> AAMIMDAKFMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3DDCA00", Offset = "0x3DDBE00", VA = "0x183DDCA00", Slot = "17")]
		public virtual void KECAPFPCLAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType MOEDOIBIGBN();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void ACFOLHELBOA(ProtobufType DCDKNCLFOJA);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void BLKPEFJHKLD(byte[] CEDPBLNCMGB);
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
			[Cpp2IlInjected.Address(RVA = "0x7EA420", Offset = "0x7E9820", VA = "0x1807EA420", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x98D6C0", Offset = "0x98CAC0", VA = "0x18098D6C0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x19669F0", Offset = "0x1965DF0", VA = "0x1819669F0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x35959D0", Offset = "0x3594DD0", VA = "0x1835959D0")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3B16790", Offset = "0x3B15B90", VA = "0x183B16790")]
		public SerializedMutableOverridableBase(bool MBOBIPBNHLD, InnerType FDFHGIHHGHO)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, ONIKKCCJGJF>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5F1EF20", Offset = "0x5F1E320", VA = "0x185F1EF20")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5F1EF80", Offset = "0x5F1E380", VA = "0x185F1EF80")]
		public MutableOverridableObscuredInt(bool MBOBIPBNHLD, ObscuredInt FDFHGIHHGHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5F1EE50", Offset = "0x5F1E250", VA = "0x185F1EE50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5F1EC90", Offset = "0x5F1E090", VA = "0x185F1EC90", Slot = "20")]
		public override void BLKPEFJHKLD(byte[] CEDPBLNCMGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5F1EBE0", Offset = "0x5F1DFE0", VA = "0x185F1EBE0", Slot = "19")]
		public override void ACFOLHELBOA(ONIKKCCJGJF DCDKNCLFOJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5F1ED70", Offset = "0x5F1E170", VA = "0x185F1ED70", Slot = "18")]
		public override ONIKKCCJGJF MOEDOIBIGBN()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, DEOMLFKOCDO>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5F1EB10", Offset = "0x5F1DF10", VA = "0x185F1EB10")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5F1EB70", Offset = "0x5F1DF70", VA = "0x185F1EB70")]
		public MutableOverridableObscuredFloat(bool MBOBIPBNHLD, ObscuredFloat FDFHGIHHGHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5F1EA40", Offset = "0x5F1DE40", VA = "0x185F1EA40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5F1E870", Offset = "0x5F1DC70", VA = "0x185F1E870", Slot = "20")]
		public override void BLKPEFJHKLD(byte[] CEDPBLNCMGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5F1E7B0", Offset = "0x5F1DBB0", VA = "0x185F1E7B0", Slot = "19")]
		public override void ACFOLHELBOA(DEOMLFKOCDO DCDKNCLFOJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5F1E950", Offset = "0x5F1DD50", VA = "0x185F1E950", Slot = "18")]
		public override DEOMLFKOCDO MOEDOIBIGBN()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, JHJDKLEPOMM>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5F1D9C0", Offset = "0x5F1CDC0", VA = "0x185F1D9C0")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5F1E740", Offset = "0x5F1DB40", VA = "0x185F1E740")]
		public MutableOverridableObscuredBool(bool MBOBIPBNHLD, ObscuredBool FDFHGIHHGHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5F1E670", Offset = "0x5F1DA70", VA = "0x185F1E670", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5F1E410", Offset = "0x5F1D810", VA = "0x185F1E410", Slot = "20")]
		public override void BLKPEFJHKLD(byte[] CEDPBLNCMGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5F1E350", Offset = "0x5F1D750", VA = "0x185F1E350", Slot = "19")]
		public override void ACFOLHELBOA(JHJDKLEPOMM DCDKNCLFOJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5F1E4F0", Offset = "0x5F1D8F0", VA = "0x185F1E4F0", Slot = "18")]
		public override JHJDKLEPOMM MOEDOIBIGBN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5F1E5E0", Offset = "0x5F1D9E0", VA = "0x185F1E5E0", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, NFODOCEFBFB<ObscuredBool>, APLFLNLCFMO<ObscuredBool>, LJMAANFHOEL<ObscuredBool>, BHDFBGPBBLL
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x79F210", Offset = "0x79E610", VA = "0x18079F210", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x79F1D0", Offset = "0x79E5D0", VA = "0x18079F1D0", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5F1D9C0", Offset = "0x5F1CDC0", VA = "0x185F1D9C0")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5F1D940", Offset = "0x5F1CD40", VA = "0x185F1D940")]
		public void KOAPJIPKLFK(MutableOverridableDefaultableObscuredBool AAMIMDAKFMC)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, ONIKKCCJGJF> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x41A63A0", Offset = "0x41A57A0", VA = "0x1841A63A0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x41A64D0", Offset = "0x41A58D0", VA = "0x1841A64D0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x359BFC0", Offset = "0x359B3C0", VA = "0x18359BFC0")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x41A6380", Offset = "0x41A5780", VA = "0x1841A6380")]
		public SerializedMutableOverridableObscuredEnum(bool MBOBIPBNHLD, TObsEnum FDFHGIHHGHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x41A6290", Offset = "0x41A5690", VA = "0x1841A6290", Slot = "18")]
		public sealed override ONIKKCCJGJF MOEDOIBIGBN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x41A6040", Offset = "0x41A5440", VA = "0x1841A6040", Slot = "19")]
		public sealed override void ACFOLHELBOA(ONIKKCCJGJF DCDKNCLFOJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x41A6140", Offset = "0x41A5540", VA = "0x1841A6140", Slot = "20")]
		public sealed override void BLKPEFJHKLD(byte[] CEDPBLNCMGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x41A6220", Offset = "0x41A5620", VA = "0x1841A6220", Slot = "17")]
		public sealed override void KECAPFPCLAM()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, ICEKBDPFADI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x5F1E280", Offset = "0x5F1D680", VA = "0x185F1E280", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x5F1E2C0", Offset = "0x5F1D6C0", VA = "0x185F1E2C0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5F1E1E0", Offset = "0x5F1D5E0", VA = "0x185F1E1E0")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5F1E180", Offset = "0x5F1D580", VA = "0x185F1E180")]
		public MutableOverridableListObscuredString(bool MBOBIPBNHLD, List<ObscuredString> FDFHGIHHGHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5F1E0E0", Offset = "0x5F1D4E0", VA = "0x185F1E0E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5F1DE70", Offset = "0x5F1D270", VA = "0x185F1DE70", Slot = "17")]
		public override void KECAPFPCLAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5F1DD90", Offset = "0x5F1D190", VA = "0x185F1DD90", Slot = "20")]
		public override void BLKPEFJHKLD(byte[] CEDPBLNCMGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5F1DA30", Offset = "0x5F1CE30", VA = "0x185F1DA30", Slot = "19")]
		public override void ACFOLHELBOA(ICEKBDPFADI DCDKNCLFOJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5F1DF00", Offset = "0x5F1D300", VA = "0x185F1DF00", Slot = "18")]
		public override ICEKBDPFADI MOEDOIBIGBN()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : LJMAANFHOEL<Vector3>, BHDFBGPBBLL
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
			[Cpp2IlInjected.Address(RVA = "0x1A3F700", Offset = "0x1A3EB00", VA = "0x181A3F700", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5F1F210", Offset = "0x5F1E610", VA = "0x185F1F210", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x3B0B400", Offset = "0x3B0A800", VA = "0x183B0B400", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3E9D3B0", Offset = "0x3E9C7B0", VA = "0x183E9D3B0")]
		public OverridableVector3(Vector3 FDFHGIHHGHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5F1F170", Offset = "0x5F1E570", VA = "0x185F1F170", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5F1F150", Offset = "0x5F1E550", VA = "0x185F1F150")]
		public static OverridableVector3 CPALPDKLBCM(Vector3 HHFKHHNHDLP)
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
