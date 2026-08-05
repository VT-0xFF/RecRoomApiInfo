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
public interface FAJOPLFLJAH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KOAEHKPPPEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object NHHBNFMPJAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OILFMNIDJBH<T> : FAJOPLFLJAH
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T ILNPCEAPFCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KDHGPKPBLIM<T> : OILFMNIDJBH<T>, FAJOPLFLJAH
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool KOAEHKPPPEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T ILNPCEAPFCH
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
public interface JOIDOKEGCNF<T> : KDHGPKPBLIM<T>, OILFMNIDJBH<T>, FAJOPLFLJAH
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool GHHDGLHGFKM
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
	public struct OverridableInt : OILFMNIDJBH<int>, FAJOPLFLJAH
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
			[Cpp2IlInjected.Address(RVA = "0x19EDBB0", Offset = "0x19ECFB0", VA = "0x1819EDBB0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5DE0640", Offset = "0x5DDFA40", VA = "0x185DE0640", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x20A07C0", Offset = "0x209FBC0", VA = "0x1820A07C0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5DE05A0", Offset = "0x5DDF9A0", VA = "0x185DE05A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : OILFMNIDJBH<string>, FAJOPLFLJAH
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
			[Cpp2IlInjected.Address(RVA = "0x19EDBB0", Offset = "0x19ECFB0", VA = "0x1819EDBB0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8348F0", Offset = "0x833CF0", VA = "0x1808348F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8348F0", Offset = "0x833CF0", VA = "0x1808348F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0690", Offset = "0x5DDFA90", VA = "0x185DE0690", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : KDHGPKPBLIM<InnerType>, OILFMNIDJBH<InnerType>, FAJOPLFLJAH where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool KOAEHKPPPEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType ILNPCEAPFCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object NHHBNFMPJAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x3D18AF0", Offset = "0x3D17EF0", VA = "0x183D18AF0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3D187B0", Offset = "0x3D17BB0", VA = "0x183D187B0")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3D187E0", Offset = "0x3D17BE0", VA = "0x183D187E0")]
		public MutableOverridableBase(bool GKOBODNJMON, [NotNull] InnerType NMENOOMOOJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3D17EE0", Offset = "0x3D172E0", VA = "0x183D17EE0", Slot = "15")]
		public void AKHKAEDAOOF(OILFMNIDJBH<InnerType> IBBCMIHPLMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3D18320", Offset = "0x3D17720", VA = "0x183D18320", Slot = "16")]
		public void FGLMIOHELPL(OILFMNIDJBH<InnerType> LFMLAKDHEFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3D18710", Offset = "0x3D17B10", VA = "0x183D18710", Slot = "17")]
		public virtual void MADHOJJNIDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType PBGCMCBBFMF();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void FMILANKBOAB(ProtobufType GDJMBFKJDDP);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void DMIOODNOBFD(byte[] HEKMPMLNCKH);
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
			[Cpp2IlInjected.Address(RVA = "0x7C5050", Offset = "0x7C4450", VA = "0x1807C5050", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x94D380", Offset = "0x94C780", VA = "0x18094D380", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1913D80", Offset = "0x1913180", VA = "0x181913D80", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x35D01C0", Offset = "0x35CF5C0", VA = "0x1835D01C0")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3471AD0", Offset = "0x3470ED0", VA = "0x183471AD0")]
		public SerializedMutableOverridableBase(bool GKOBODNJMON, InnerType NMENOOMOOJP)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, LKDGLEMKNHA>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5DE04D0", Offset = "0x5DDF8D0", VA = "0x185DE04D0")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0530", Offset = "0x5DDF930", VA = "0x185DE0530")]
		public MutableOverridableObscuredInt(bool GKOBODNJMON, ObscuredInt NMENOOMOOJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0400", Offset = "0x5DDF800", VA = "0x185DE0400", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0190", Offset = "0x5DDF590", VA = "0x185DE0190", Slot = "20")]
		public override void DMIOODNOBFD(byte[] HEKMPMLNCKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0270", Offset = "0x5DDF670", VA = "0x185DE0270", Slot = "19")]
		public override void FMILANKBOAB(LKDGLEMKNHA GDJMBFKJDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0320", Offset = "0x5DDF720", VA = "0x185DE0320", Slot = "18")]
		public override LKDGLEMKNHA PBGCMCBBFMF()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, IINHLHADNBN>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5DE00C0", Offset = "0x5DDF4C0", VA = "0x185DE00C0")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0120", Offset = "0x5DDF520", VA = "0x185DE0120")]
		public MutableOverridableObscuredFloat(bool GKOBODNJMON, ObscuredFloat NMENOOMOOJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5DDFFF0", Offset = "0x5DDF3F0", VA = "0x185DDFFF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5DDFD60", Offset = "0x5DDF160", VA = "0x185DDFD60", Slot = "20")]
		public override void DMIOODNOBFD(byte[] HEKMPMLNCKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5DDFE40", Offset = "0x5DDF240", VA = "0x185DDFE40", Slot = "19")]
		public override void FMILANKBOAB(IINHLHADNBN GDJMBFKJDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5DDFF00", Offset = "0x5DDF300", VA = "0x185DDFF00", Slot = "18")]
		public override IINHLHADNBN PBGCMCBBFMF()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, JOFOOBDNBON>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5DDEF70", Offset = "0x5DDE370", VA = "0x185DDEF70")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5DDFCF0", Offset = "0x5DDF0F0", VA = "0x185DDFCF0")]
		public MutableOverridableObscuredBool(bool GKOBODNJMON, ObscuredBool NMENOOMOOJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5DDFC20", Offset = "0x5DDF020", VA = "0x185DDFC20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5DDF900", Offset = "0x5DDED00", VA = "0x185DDF900", Slot = "20")]
		public override void DMIOODNOBFD(byte[] HEKMPMLNCKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5DDF9E0", Offset = "0x5DDEDE0", VA = "0x185DDF9E0", Slot = "19")]
		public override void FMILANKBOAB(JOFOOBDNBON GDJMBFKJDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5DDFB30", Offset = "0x5DDEF30", VA = "0x185DDFB30", Slot = "18")]
		public override JOFOOBDNBON PBGCMCBBFMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5DDFAA0", Offset = "0x5DDEEA0", VA = "0x185DDFAA0", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, JOIDOKEGCNF<ObscuredBool>, KDHGPKPBLIM<ObscuredBool>, OILFMNIDJBH<ObscuredBool>, FAJOPLFLJAH
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x773820", Offset = "0x772C20", VA = "0x180773820", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x773870", Offset = "0x772C70", VA = "0x180773870", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5DDEF70", Offset = "0x5DDE370", VA = "0x185DDEF70")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5DDEEF0", Offset = "0x5DDE2F0", VA = "0x185DDEEF0")]
		public void AKHKAEDAOOF(MutableOverridableDefaultableObscuredBool LFMLAKDHEFO)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, LKDGLEMKNHA> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x40FFCE0", Offset = "0x40FF0E0", VA = "0x1840FFCE0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x40FFE10", Offset = "0x40FF210", VA = "0x1840FFE10", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3528C10", Offset = "0x3528010", VA = "0x183528C10")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x40FFCC0", Offset = "0x40FF0C0", VA = "0x1840FFCC0")]
		public SerializedMutableOverridableObscuredEnum(bool GKOBODNJMON, TObsEnum NMENOOMOOJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x40FFBD0", Offset = "0x40FEFD0", VA = "0x1840FFBD0", Slot = "18")]
		public sealed override LKDGLEMKNHA PBGCMCBBFMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x40FFA60", Offset = "0x40FEE60", VA = "0x1840FFA60", Slot = "19")]
		public sealed override void FMILANKBOAB(LKDGLEMKNHA GDJMBFKJDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x40FF980", Offset = "0x40FED80", VA = "0x1840FF980", Slot = "20")]
		public sealed override void DMIOODNOBFD(byte[] HEKMPMLNCKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x40FFB60", Offset = "0x40FEF60", VA = "0x1840FFB60", Slot = "17")]
		public sealed override void MADHOJJNIDP()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, MNOIMDLJDIA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x5DDF830", Offset = "0x5DDEC30", VA = "0x185DDF830", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x5DDF870", Offset = "0x5DDEC70", VA = "0x185DDF870", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5DDF790", Offset = "0x5DDEB90", VA = "0x185DDF790")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5DDF730", Offset = "0x5DDEB30", VA = "0x185DDF730")]
		public MutableOverridableListObscuredString(bool GKOBODNJMON, List<ObscuredString> NMENOOMOOJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5DDF690", Offset = "0x5DDEA90", VA = "0x185DDF690", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5DDF420", Offset = "0x5DDE820", VA = "0x185DDF420", Slot = "17")]
		public override void MADHOJJNIDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5DDEFE0", Offset = "0x5DDE3E0", VA = "0x185DDEFE0", Slot = "20")]
		public override void DMIOODNOBFD(byte[] HEKMPMLNCKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5DDF0C0", Offset = "0x5DDE4C0", VA = "0x185DDF0C0", Slot = "19")]
		public override void FMILANKBOAB(MNOIMDLJDIA GDJMBFKJDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5DDF4B0", Offset = "0x5DDE8B0", VA = "0x185DDF4B0", Slot = "18")]
		public override MNOIMDLJDIA PBGCMCBBFMF()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : OILFMNIDJBH<Vector3>, FAJOPLFLJAH
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
			[Cpp2IlInjected.Address(RVA = "0x19EDBB0", Offset = "0x19ECFB0", VA = "0x1819EDBB0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5DE07C0", Offset = "0x5DDFBC0", VA = "0x185DE07C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x3A642B0", Offset = "0x3A636B0", VA = "0x183A642B0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3DC7C90", Offset = "0x3DC7090", VA = "0x183DC7C90")]
		public OverridableVector3(Vector3 NMENOOMOOJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0720", Offset = "0x5DDFB20", VA = "0x185DE0720", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0700", Offset = "0x5DDFB00", VA = "0x185DE0700")]
		public static OverridableVector3 GOCBKKMEEIH(Vector3 OKHKFFGCACL)
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
