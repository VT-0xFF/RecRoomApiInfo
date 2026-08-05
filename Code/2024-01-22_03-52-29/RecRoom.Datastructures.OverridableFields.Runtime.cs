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
public interface AOBNEFEOEBJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool CMPOOCEEMOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object FJKHHAKNGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MEAJMNIOEGN<T> : AOBNEFEOEBJ
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T BFBAIKCHJBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface AHIHNIOOCAD<T> : MEAJMNIOEGN<T>, AOBNEFEOEBJ
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool CMPOOCEEMOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T BFBAIKCHJBC
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
public interface INNDLBOKNLD<T> : AHIHNIOOCAD<T>, MEAJMNIOEGN<T>, AOBNEFEOEBJ
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool MPBHODJIABK
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
	public struct OverridableInt : MEAJMNIOEGN<int>, AOBNEFEOEBJ
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
			[Cpp2IlInjected.Address(RVA = "0x1A363D0", Offset = "0x1A357D0", VA = "0x181A363D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5FE0D80", Offset = "0x5FE0180", VA = "0x185FE0D80", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2167AC0", Offset = "0x2166EC0", VA = "0x182167AC0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0CE0", Offset = "0x5FE00E0", VA = "0x185FE0CE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : MEAJMNIOEGN<string>, AOBNEFEOEBJ
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
			[Cpp2IlInjected.Address(RVA = "0x1A363D0", Offset = "0x1A357D0", VA = "0x181A363D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x886CF0", Offset = "0x8860F0", VA = "0x180886CF0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x886CF0", Offset = "0x8860F0", VA = "0x180886CF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0DD0", Offset = "0x5FE01D0", VA = "0x185FE0DD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : AHIHNIOOCAD<InnerType>, MEAJMNIOEGN<InnerType>, AOBNEFEOEBJ where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool CMPOOCEEMOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType BFBAIKCHJBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object FJKHHAKNGGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x1F80920", Offset = "0x1F7FD20", VA = "0x181F80920", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3E64BB0", Offset = "0x3E63FB0", VA = "0x183E64BB0")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3E64BE0", Offset = "0x3E63FE0", VA = "0x183E64BE0")]
		public MutableOverridableBase(bool BJCPCLINHHG, [NotNull] InnerType PAHKKNONPEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3E646D0", Offset = "0x3E63AD0", VA = "0x183E646D0", Slot = "15")]
		public void DEGOGPOEOAL(MEAJMNIOEGN<InnerType> NLJHOACJBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3E64790", Offset = "0x3E63B90", VA = "0x183E64790", Slot = "16")]
		public void EFBMDIDFCOL(MEAJMNIOEGN<InnerType> JLCJEDAFKJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3E64340", Offset = "0x3E63740", VA = "0x183E64340", Slot = "17")]
		public virtual void AIKIIHKLAJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType OPGEMKGBKCE();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void LONBLAHFBKG(ProtobufType CIBBDCBMGGI);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void CDBEEDDNLLD(byte[] NFLKAKJEJFP);
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
			[Cpp2IlInjected.Address(RVA = "0x7E0B90", Offset = "0x7DFF90", VA = "0x1807E0B90", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x97ED30", Offset = "0x97E130", VA = "0x18097ED30", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x196A770", Offset = "0x1969B70", VA = "0x18196A770", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x36B9820", Offset = "0x36B8C20", VA = "0x1836B9820")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x381D050", Offset = "0x381C450", VA = "0x18381D050")]
		public SerializedMutableOverridableBase(bool BJCPCLINHHG, InnerType PAHKKNONPEO)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, OGCFNILBLOM>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0C10", Offset = "0x5FE0010", VA = "0x185FE0C10")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0C70", Offset = "0x5FE0070", VA = "0x185FE0C70")]
		public MutableOverridableObscuredInt(bool BJCPCLINHHG, ObscuredInt PAHKKNONPEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0B40", Offset = "0x5FDFF40", VA = "0x185FE0B40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5FE08D0", Offset = "0x5FDFCD0", VA = "0x185FE08D0", Slot = "20")]
		public override void CDBEEDDNLLD(byte[] NFLKAKJEJFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5FE09B0", Offset = "0x5FDFDB0", VA = "0x185FE09B0", Slot = "19")]
		public override void LONBLAHFBKG(OGCFNILBLOM CIBBDCBMGGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0A60", Offset = "0x5FDFE60", VA = "0x185FE0A60", Slot = "18")]
		public override OGCFNILBLOM OPGEMKGBKCE()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, FBGMCLMMHEM>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0800", Offset = "0x5FDFC00", VA = "0x185FE0800")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0860", Offset = "0x5FDFC60", VA = "0x185FE0860")]
		public MutableOverridableObscuredFloat(bool BJCPCLINHHG, ObscuredFloat PAHKKNONPEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0730", Offset = "0x5FDFB30", VA = "0x185FE0730", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5FE04A0", Offset = "0x5FDF8A0", VA = "0x185FE04A0", Slot = "20")]
		public override void CDBEEDDNLLD(byte[] NFLKAKJEJFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0580", Offset = "0x5FDF980", VA = "0x185FE0580", Slot = "19")]
		public override void LONBLAHFBKG(FBGMCLMMHEM CIBBDCBMGGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0640", Offset = "0x5FDFA40", VA = "0x185FE0640", Slot = "18")]
		public override FBGMCLMMHEM OPGEMKGBKCE()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, AJDFMFFAMBN>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5FDF6B0", Offset = "0x5FDEAB0", VA = "0x185FDF6B0")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0430", Offset = "0x5FDF830", VA = "0x185FE0430")]
		public MutableOverridableObscuredBool(bool BJCPCLINHHG, ObscuredBool PAHKKNONPEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0360", Offset = "0x5FDF760", VA = "0x185FE0360", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0040", Offset = "0x5FDF440", VA = "0x185FE0040", Slot = "20")]
		public override void CDBEEDDNLLD(byte[] NFLKAKJEJFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0120", Offset = "0x5FDF520", VA = "0x185FE0120", Slot = "19")]
		public override void LONBLAHFBKG(AJDFMFFAMBN CIBBDCBMGGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5FE01E0", Offset = "0x5FDF5E0", VA = "0x185FE01E0", Slot = "18")]
		public override AJDFMFFAMBN OPGEMKGBKCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5FE02D0", Offset = "0x5FDF6D0", VA = "0x185FE02D0", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, INNDLBOKNLD<ObscuredBool>, AHIHNIOOCAD<ObscuredBool>, MEAJMNIOEGN<ObscuredBool>, AOBNEFEOEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x793FF0", Offset = "0x7933F0", VA = "0x180793FF0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7940E0", Offset = "0x7934E0", VA = "0x1807940E0", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5FDF6B0", Offset = "0x5FDEAB0", VA = "0x185FDF6B0")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5FDF630", Offset = "0x5FDEA30", VA = "0x185FDF630")]
		public void DEGOGPOEOAL(MutableOverridableDefaultableObscuredBool JLCJEDAFKJL)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, OGCFNILBLOM> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x4261420", Offset = "0x4260820", VA = "0x184261420", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x4261550", Offset = "0x4260950", VA = "0x184261550", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x392F210", Offset = "0x392E610", VA = "0x18392F210")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4261400", Offset = "0x4260800", VA = "0x184261400")]
		public SerializedMutableOverridableObscuredEnum(bool BJCPCLINHHG, TObsEnum PAHKKNONPEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4261310", Offset = "0x4260710", VA = "0x184261310", Slot = "18")]
		public sealed override OGCFNILBLOM OPGEMKGBKCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4261210", Offset = "0x4260610", VA = "0x184261210", Slot = "19")]
		public sealed override void LONBLAHFBKG(OGCFNILBLOM CIBBDCBMGGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4261130", Offset = "0x4260530", VA = "0x184261130", Slot = "20")]
		public sealed override void CDBEEDDNLLD(byte[] NFLKAKJEJFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x42610C0", Offset = "0x42604C0", VA = "0x1842610C0", Slot = "17")]
		public sealed override void AIKIIHKLAJH()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, OIAMBBJOFGM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x5FDFF70", Offset = "0x5FDF370", VA = "0x185FDFF70", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x5FDFFB0", Offset = "0x5FDF3B0", VA = "0x185FDFFB0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5FDFED0", Offset = "0x5FDF2D0", VA = "0x185FDFED0")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5FDFE70", Offset = "0x5FDF270", VA = "0x185FDFE70")]
		public MutableOverridableListObscuredString(bool BJCPCLINHHG, List<ObscuredString> PAHKKNONPEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5FDFDD0", Offset = "0x5FDF1D0", VA = "0x185FDFDD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5FDF720", Offset = "0x5FDEB20", VA = "0x185FDF720", Slot = "17")]
		public override void AIKIIHKLAJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5FDF7B0", Offset = "0x5FDEBB0", VA = "0x185FDF7B0", Slot = "20")]
		public override void CDBEEDDNLLD(byte[] NFLKAKJEJFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5FDF890", Offset = "0x5FDEC90", VA = "0x185FDF890", Slot = "19")]
		public override void LONBLAHFBKG(OIAMBBJOFGM CIBBDCBMGGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5FDFBF0", Offset = "0x5FDEFF0", VA = "0x185FDFBF0", Slot = "18")]
		public override OIAMBBJOFGM OPGEMKGBKCE()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : MEAJMNIOEGN<Vector3>, AOBNEFEOEBJ
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
			[Cpp2IlInjected.Address(RVA = "0x1A363D0", Offset = "0x1A357D0", VA = "0x181A363D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5FE0F00", Offset = "0x5FE0300", VA = "0x185FE0F00", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x3BEC360", Offset = "0x3BEB760", VA = "0x183BEC360", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3F587A0", Offset = "0x3F57BA0", VA = "0x183F587A0")]
		public OverridableVector3(Vector3 PAHKKNONPEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0E60", Offset = "0x5FE0260", VA = "0x185FE0E60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0E40", Offset = "0x5FE0240", VA = "0x185FE0E40")]
		public static OverridableVector3 OOICJOKLJBF(Vector3 OFNBMJMBJHA)
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
