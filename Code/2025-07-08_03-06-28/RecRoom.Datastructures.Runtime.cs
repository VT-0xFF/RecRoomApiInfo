using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecRoom.Attributes;
using RecRoom.Core.DataStructures;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x80811D0", Offset = "0x807FFD0", VA = "0x1880811D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA838A0", Offset = "0xA826A0", VA = "0x180A838A0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA838E0", Offset = "0xA826E0", VA = "0x180A838E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class CKMNMEHDKJJ : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x22D54F0", Offset = "0x22D42F0", VA = "0x1822D54F0")]
	public CKMNMEHDKJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, JLNNICPJFOO, EKNKHLNLFEE, ISerializationCallbackReceiver
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[SerializeField]
	private byte[] stableHash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	private byte[] seed;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public byte[] StableHash
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA595A0", Offset = "0xA583A0", VA = "0x180A595A0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58660", VA = "0x180A59860", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA595B0", Offset = "0xA583B0", VA = "0x180A595B0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD87780", Offset = "0xD86580", VA = "0x180D87780", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash MOOBNHLGDMK);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xCC5E40", Offset = "0xCC4C40", VA = "0x180CC5E40")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[SerializeField]
	[ReadOnlyField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[SerializeField]
	[ReadOnlyField]
	[HideInInspector]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x80823E0", Offset = "0x80811E0", VA = "0x1880823E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x80823A0", Offset = "0x80811A0", VA = "0x1880823A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8082420", Offset = "0x8081220", VA = "0x188082420")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x80825D0", Offset = "0x80813D0", VA = "0x1880825D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8082540", Offset = "0x8081340", VA = "0x188082540")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xAB2D70", Offset = "0xAB1B70", VA = "0x180AB2D70")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xAB30B0", Offset = "0xAB1EB0", VA = "0x180AB30B0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8082360", Offset = "0x8081160", VA = "0x188082360")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x80824B0", Offset = "0x80812B0", VA = "0x1880824B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8081EC0", Offset = "0x8080CC0", VA = "0x188081EC0")]
	public void CopyBounds(SavedExtents LOKLFHKEJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x80822B0", Offset = "0x80810B0", VA = "0x1880822B0")]
	public void SetLocalSpaceBounds(Bounds JCDDJICNKDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1622CE0", Offset = "0x1621AE0", VA = "0x181622CE0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x80822A0", Offset = "0x80810A0", VA = "0x1880822A0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8081EF0", Offset = "0x8080CF0", VA = "0x188081EF0")]
	private void HDPNLLFIFAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x80820A0", Offset = "0x8080EA0", VA = "0x1880820A0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8081850", Offset = "0x8080650", VA = "0x188081850")]
	public static void CalculateLocalBoundsFor(GameObject JLNNGPHDMLM, [Out] Bounds JCDDJICNKDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8081790", Offset = "0x8080590", VA = "0x188081790")]
	private static void BFNGHEHLCBJ(Bounds MANCHAKPLNN, Color BEIDDJJHBIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x80822D0", Offset = "0x80810D0", VA = "0x1880822D0")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA57180", Offset = "0xA55F80", VA = "0x180A57180")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA5A3F0", Offset = "0xA591F0", VA = "0x180A5A3F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1AE6CE0", Offset = "0x1AE5AE0", VA = "0x181AE6CE0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5BE0B10", Offset = "0x5BDF910", VA = "0x185BE0B10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "4")]
	public virtual void COCHKMEFBDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[CKMNMEHDKJJ]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5BE06F0", Offset = "0x5BDF4F0", VA = "0x185BE06F0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5BDF3E0", Offset = "0x5BDE1E0", VA = "0x185BDF3E0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5BE0A60", Offset = "0x5BDF860", VA = "0x185BE0A60")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class PEIJCAAPMHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public PEIJCAAPMHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5979E80", Offset = "0x5978C80", VA = "0x185979E80")]
		internal int BFPBJBOJENK(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[CKMNMEHDKJJ]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x484A5B0", Offset = "0x48493B0", VA = "0x18484A5B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x484A600", Offset = "0x4849400", VA = "0x18484A600", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x484A4B0", Offset = "0x48492B0", VA = "0x18484A4B0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey MAHBBBBCDEL]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x484A550", Offset = "0x4849350", VA = "0x18484A550", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x484A390", Offset = "0x4849190", VA = "0x18484A390", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x484A0A0", Offset = "0x4848EA0", VA = "0x18484A0A0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x48494E0", Offset = "0x48482E0", VA = "0x1848494E0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x48494B0", Offset = "0x48482B0", VA = "0x1848494B0", Slot = "14")]
	protected virtual string JOOOKHELCHJ(TKeyVal DNMKHJLFBLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4849360", Offset = "0x4848160", VA = "0x184849360", Slot = "4")]
	public bool ContainsKey(TKey MAHBBBBCDEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x484A250", Offset = "0x4849050", VA = "0x18484A250", Slot = "5")]
	public bool TryGetValue(TKey MAHBBBBCDEL, [Out] TVal BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x48493B0", Offset = "0x48481B0", VA = "0x1848493B0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x48493B0", Offset = "0x48481B0", VA = "0x1848493B0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x484A2A0", Offset = "0x48490A0", VA = "0x18484A2A0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class SerializedReferenceKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[SerializeReference]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA59840", Offset = "0xA58640", VA = "0x180A59840")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA595A0", Offset = "0xA583A0", VA = "0x180A595A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	protected SerializedReferenceKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class SerializedReferenceDictionary<TKey, TVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private class SerializedReferenceKeyValuePair : SerializedReferenceKeyVal<TKey, TVal>
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x47D2410", Offset = "0x47D1210", VA = "0x1847D2410")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	[CKMNMEHDKJJ]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5BE22F0", Offset = "0x5BE10F0", VA = "0x185BE22F0")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5BE1BB0", Offset = "0x5BE09B0", VA = "0x185BE1BB0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5BE11A0", Offset = "0x5BDFFA0", VA = "0x185BE11A0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class NANBDHCMNKE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct MDEEACGFKDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public T HBDLGDLEPJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public float KPILEMPIFAH;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int OFBMBIFMJNC = 16;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const float PPAKBFDLOFE = -1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected readonly MDEEACGFKDN[] COPOPHFGNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	protected int DEMJEDIALDK;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float KIEDJCIAPBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xD261F0", Offset = "0xD24FF0", VA = "0x180D261F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xD661E0", Offset = "0xD64FE0", VA = "0x180D661E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public T PNGOMFGFBPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA595A0", Offset = "0xA583A0", VA = "0x180A595A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x56CD310", Offset = "0x56CC110", VA = "0x1856CD310")]
	protected NANBDHCMNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x56CD290", Offset = "0x56CC090", VA = "0x1856CD290")]
	protected NANBDHCMNKE(int DFCCCGNJINK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x56CD0D0", Offset = "0x56CBED0", VA = "0x1856CD0D0")]
	public void OLHPIGGMIDE(float GJEILCNCAPN, T BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool OBFDBELNINF(float JJLJKJFEDOP, float NNJPCGBFIBO, [Out] T BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool OBOBGLHJEEA(float JJLJKJFEDOP, float NNJPCGBFIBO, [Out] T BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x56CD010", Offset = "0x56CBE10", VA = "0x1856CD010")]
	public void MKDKKBLDFOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class IDJCOHBKFOK : NANBDHCMNKE<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8080120", Offset = "0x807EF20", VA = "0x188080120", Slot = "4")]
	public override bool OBFDBELNINF(float JJLJKJFEDOP, float NNJPCGBFIBO, [Out] Vector3 BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8080280", Offset = "0x807F080", VA = "0x188080280", Slot = "5")]
	public override bool OBOBGLHJEEA(float JJLJKJFEDOP, float NNJPCGBFIBO, [Out] Vector3 BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x80803C0", Offset = "0x807F1C0", VA = "0x1880803C0")]
	public IDJCOHBKFOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class JJBCFJKCMCL
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3BED5B0", Offset = "0x3BEC3B0", VA = "0x183BED5B0")]
	public static NODKPMBMKPG<T1, T2> LDFHHMLGJNG<T1, T2>(T1 PMBNBBEKDMH, T2 FIDLKBOEGDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3BED630", Offset = "0x3BEC430", VA = "0x183BED630")]
	public static LCJKIBKPJAB<T1, T2, T3> LDFHHMLGJNG<T1, T2, T3>(T1 PMBNBBEKDMH, T2 FIDLKBOEGDB, T3 KOABOPNIDPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x56BDE30", Offset = "0x56BCC30", VA = "0x1856BDE30")]
	internal static int KCMFJEBNEDK(int NIAAGIJONLB, int HKBFGMIFCDC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7226BE0", Offset = "0x72259E0", VA = "0x187226BE0")]
	internal static int KCMFJEBNEDK(int NIAAGIJONLB, int HKBFGMIFCDC, int MBFKOPIABAC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class NODKPMBMKPG<T1, T2> : IComparable<NODKPMBMKPG<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T1 GNKHICJLIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T2 BNDGFHOOJLA;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x57142D0", Offset = "0x57130D0", VA = "0x1857142D0")]
	public NODKPMBMKPG(T1 PMBNBBEKDMH, T2 FIDLKBOEGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x57126F0", Offset = "0x57114F0", VA = "0x1857126F0", Slot = "4")]
	public int CompareTo(NODKPMBMKPG<T1, T2> LOKLFHKEJPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5712BE0", Offset = "0x57119E0", VA = "0x185712BE0", Slot = "0")]
	public override bool Equals(object LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x57136B0", Offset = "0x57124B0", VA = "0x1857136B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5713DE0", Offset = "0x5712BE0", VA = "0x185713DE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class LCJKIBKPJAB<T1, T2, T3> : IComparable<LCJKIBKPJAB<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T1 GNKHICJLIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T2 BNDGFHOOJLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T3 OLIHDCJKMNL;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5408680", Offset = "0x5407480", VA = "0x185408680")]
	public LCJKIBKPJAB(T1 PMBNBBEKDMH, T2 FIDLKBOEGDB, T3 KOABOPNIDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5407E60", Offset = "0x5406C60", VA = "0x185407E60", Slot = "4")]
	public int CompareTo(LCJKIBKPJAB<T1, T2, T3> LOKLFHKEJPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5407FA0", Offset = "0x5406DA0", VA = "0x185407FA0", Slot = "0")]
	public override bool Equals(object LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5408310", Offset = "0x5407110", VA = "0x185408310", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x54083B0", Offset = "0x54071B0", VA = "0x1854083B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public AnimationCurve HCNOLFMMNBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T FAPPDJGGGIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1373CA0", Offset = "0x1372AA0", VA = "0x181373CA0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T CEAADIKJNIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xD16990", Offset = "0xD15790", VA = "0x180D16990")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T HBDLGDLEPJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2DDEC90", Offset = "0x2DDDA90", VA = "0x182DDEC90")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2DDEB40", Offset = "0x2DDD940", VA = "0x182DDEB40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float GNDAOBKNMKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xAA8F00", Offset = "0xAA7D00", VA = "0x180AA8F00")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA9A0", Offset = "0x5EA97A0", VA = "0x185EAA9A0")]
	public T HFLCHDAIFJN(float ODOKMLFIJNG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5EAAD70", Offset = "0x5EA9B70", VA = "0x185EAAD70")]
	public T LHIBGOGEGLA(float ODOKMLFIJNG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T AIOGAEPCKGH(T PHLJLBDJNIE, T GEOHFJAPCHG, float ODOKMLFIJNG);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x807FD90", Offset = "0x807EB90", VA = "0x18807FD90", Slot = "4")]
	protected override float AIOGAEPCKGH(float PHLJLBDJNIE, float GEOHFJAPCHG, float ODOKMLFIJNG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x807FDD0", Offset = "0x807EBD0", VA = "0x18807FDD0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x19383C0", Offset = "0x19371C0", VA = "0x1819383C0", Slot = "4")]
	protected override Vector3 AIOGAEPCKGH(Vector3 PHLJLBDJNIE, Vector3 GEOHFJAPCHG, float ODOKMLFIJNG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x80833F0", Offset = "0x80821F0", VA = "0x1880833F0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x807FB20", Offset = "0x807E920", VA = "0x18807FB20", Slot = "4")]
	protected override Color AIOGAEPCKGH(Color PHLJLBDJNIE, Color GEOHFJAPCHG, float ODOKMLFIJNG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x807FBE0", Offset = "0x807E9E0", VA = "0x18807FBE0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class CFFGKIHCBAO : JIBIHOOHDMH<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x807FAD0", Offset = "0x807E8D0", VA = "0x18807FAD0")]
	public CFFGKIHCBAO(int COJMCLGONLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x807FA60", Offset = "0x807E860", VA = "0x18807FA60", Slot = "6")]
	protected override uint PBAJPMMBLLP(uint MOOBNHLGDMK, string BNECONOIKOE)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class JNNDIFBDNNJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly IDisposable ODAOEPEFKDK;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public JNNDIFBDNNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct JOAHHIJPOMP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> LOPHIGEMEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int CFINIAPBFHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int HAEOEDDALJJ;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4EA0610", Offset = "0x4E9F410", VA = "0x184EA0610")]
	private JOAHHIJPOMP(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> IFCPINONAOP, int BLHJDNOMJFA, int PGNFEHAOEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x51F6D80", Offset = "0x51F5B80", VA = "0x1851F6D80")]
	public static JOAHHIJPOMP<T> OGAKBGHEIKK()
	{
		return default(JOAHHIJPOMP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x51F5940", Offset = "0x51F4740", VA = "0x1851F5940")]
	public (int, int, Task<T>) JMEPHDAKBKL(int FLHCGDNOCHL, [Optional] CancellationToken HIMDFBHMPLL, double JMOMPNOKIIJ = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x51F4F10", Offset = "0x51F3D10", VA = "0x1851F4F10")]
	public void ECBLOFELIJM(int FLHCGDNOCHL, int PGNFEHAOEME, [In] T OHLBIIOAJDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class JOGLHALIOBC
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8081030", Offset = "0x807FE30", VA = "0x188081030")]
	public static JOAHHIJPOMP<CIEOHCAKAMM> OGAKBGHEIKK()
	{
		return default(JOAHHIJPOMP<CIEOHCAKAMM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8080FB0", Offset = "0x807FDB0", VA = "0x188080FB0")]
	public static void ECBLOFELIJM([In] this JOAHHIJPOMP<CIEOHCAKAMM> FEOFEEGOGIO, int FLHCGDNOCHL, int PGNFEHAOEME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class BHFMKBLANEG<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly Dictionary<TKey, TVal> CBKHABFLOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TVal, TKey> CNOMENNEKDD;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int OOJPJFMJCLH
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x43AC800", Offset = "0x43AB600", VA = "0x1843AC800", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool ECOGGGAIBMA
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> JHOIMAJLEIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x548BD90", Offset = "0x548AB90", VA = "0x18548BD90", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> HIBGLNGFBED
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x62558A0", Offset = "0x62546A0", VA = "0x1862558A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal CBMLGEIEAGG
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6255840", Offset = "0x6254640", VA = "0x186255840", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6255900", Offset = "0x6254700", VA = "0x186255900", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey CBMLGEIEAGG
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x62551C0", Offset = "0x6253FC0", VA = "0x1862551C0")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6255040", Offset = "0x6253E40", VA = "0x186255040", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x62556C0", Offset = "0x62544C0", VA = "0x1862556C0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6254E00", Offset = "0x6253C00", VA = "0x186254E00", Slot = "9")]
	public void Add(TKey MAHBBBBCDEL, TVal BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6254DD0", Offset = "0x6253BD0", VA = "0x186254DD0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> EHKDLJBBGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x62550A0", Offset = "0x6253EA0", VA = "0x1862550A0", Slot = "8")]
	public bool ContainsKey(TKey MAHBBBBCDEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x62550E0", Offset = "0x6253EE0", VA = "0x1862550E0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x62555E0", Offset = "0x62543E0", VA = "0x1862555E0", Slot = "10")]
	public bool Remove(TKey MAHBBBBCDEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6255610", Offset = "0x6254410", VA = "0x186255610", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6255710", Offset = "0x6254510", VA = "0x186255710", Slot = "11")]
	public bool TryGetValue(TKey MAHBBBBCDEL, [Out] TVal BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6255260", Offset = "0x6254060", VA = "0x186255260", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6255140", Offset = "0x6253F40", VA = "0x186255140", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] COPOPHFGNFG, int PENDJAKLNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6254EC0", Offset = "0x6253CC0", VA = "0x186254EC0")]
	public bool BNILIKGEJAF(TVal MAHBBBBCDEL, [Out] TKey BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6255390", Offset = "0x6254190", VA = "0x186255390")]
	private void PDHLHODCLIG(TKey MAHBBBBCDEL, TVal HBLCHHJHKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6254FA0", Offset = "0x6253DA0", VA = "0x186254FA0")]
	private void CAPKGGJHJFE(TKey MAHBBBBCDEL, TVal HBLCHHJHKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6255430", Offset = "0x6254230", VA = "0x186255430")]
	private bool PMPLAMFNABF(TKey MAHBBBBCDEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6255750", Offset = "0x6254550", VA = "0x186255750")]
	public BHFMKBLANEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class FMFCINCIEJA<T> : IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private FMFCINCIEJA<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x145FD20", Offset = "0x145EB20", VA = "0x18145FD20", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x48B7ED0", Offset = "0x48B6CD0", VA = "0x1848B7ED0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x48B8A70", Offset = "0x48B7870", VA = "0x1848B8A70")]
		public Enumerator(FMFCINCIEJA<T> NHMENHDBHGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x48B6830", Offset = "0x48B5630", VA = "0x1848B6830", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x48B7570", Offset = "0x48B6370", VA = "0x1848B7570", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x48B5C30", Offset = "0x48B4A30", VA = "0x1848B5C30")]
		private void GDEOMJGKHAO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private T[] DFNCBGDAHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int HBNCFIPENFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int IOAKGBLJAAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int DMIBKIHBLCP;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int OOJPJFMJCLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x4CD04C0", Offset = "0x4CCF2C0", VA = "0x184CD04C0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T CBMLGEIEAGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4CCD950", Offset = "0x4CCC750", VA = "0x184CCD950")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x4CCDBA0", Offset = "0x4CCC9A0", VA = "0x184CCDBA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4CD0440", Offset = "0x4CCF240", VA = "0x184CD0440")]
	public FMFCINCIEJA(int COJMCLGONLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4CCFC90", Offset = "0x4CCEA90", VA = "0x184CCFC90")]
	public void OLHPIGGMIDE(T ODOKMLFIJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4CCEA00", Offset = "0x4CCD800", VA = "0x184CCEA00")]
	public void MBGFCNOCIDA(IEnumerable<T> FANOBLNBIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4CCFAD0", Offset = "0x4CCE8D0", VA = "0x184CCFAD0")]
	public void MKDKKBLDFOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4CCD7A0", Offset = "0x4CCC5A0", VA = "0x184CCD7A0")]
	public void CFNCBFFGNGB(int LJEIHABMGGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4CCE3B0", Offset = "0x4CCD1B0", VA = "0x184CCE3B0")]
	public void HPANNKPMOKF(T[] COPOPHFGNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4CD0020", Offset = "0x4CCEE20", VA = "0x184CD0020")]
	public Enumerator OMGGHMFPBJO()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4CD0310", Offset = "0x4CCF110", VA = "0x184CD0310", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4CD0310", Offset = "0x4CCF110", VA = "0x184CD0310", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4CCD330", Offset = "0x4CCC130", VA = "0x184CCD330")]
	private int AMGKDIOHDHN(int CKFKPOAGPKN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4CCD770", Offset = "0x4CCC570", VA = "0x184CCD770")]
	private int BHMIKFBILOK(int CKFKPOAGPKN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class GFPGBBFBAJF<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate Task<TResult> PMIBAOFHHHG(TRequest OHNONCFAIKH, CancellationToken HIMDFBHMPLL);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum BEHJDCMAGOD
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class OLOAJGJLGAO
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const float PMENHHHJDID = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TimeSpan AJAFNIPJGMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int GGCBOMILBGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public BEHJDCMAGOD HGMFNOBDLHF;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly OLOAJGJLGAO CLGJEJAIGBE;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float EPFHKJCCGCF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x5865E50", Offset = "0x5864C50", VA = "0x185865E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public TimeSpan DCNOKMPFIEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x5866080", Offset = "0x5864E80", VA = "0x185866080")]
		public OLOAJGJLGAO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private readonly struct NPNAIMDDEEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public readonly TRequest OHNONCFAIKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly CancellationToken HIMDFBHMPLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly TaskCompletionSource<TResult> KPLLGNNGGHN;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x573CDB0", Offset = "0x573BBB0", VA = "0x18573CDB0")]
		public NPNAIMDDEEL(TRequest OHNONCFAIKH, TaskCompletionSource<TResult> KPLLGNNGGHN, CancellationToken HIMDFBHMPLL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct OJMDGMOFJFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public GFPGBBFBAJF<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x585D620", Offset = "0x585C420", VA = "0x18585D620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x585DAC0", Offset = "0x585C8C0", VA = "0x18585DAC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct PENIAPHFPCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public GFPGBBFBAJF<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private NPNAIMDDEEL <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x597A670", Offset = "0x5979470", VA = "0x18597A670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x597B240", Offset = "0x597A040", VA = "0x18597B240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CancellationTokenSource PEPHBAGAOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly List<NPNAIMDDEEL> NCMEAEEOODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly OLOAJGJLGAO JLIDPBFEMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly PMIBAOFHHHG KNMGPNHBEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Task PLBHGFFOPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int MCINAMCBFGI;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4D84460", Offset = "0x4D83260", VA = "0x184D84460")]
	public GFPGBBFBAJF(PMIBAOFHHHG KNMGPNHBEBN, [Optional] OLOAJGJLGAO JLIDPBFEMMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4D84020", Offset = "0x4D82E20", VA = "0x184D84020")]
	public Task<TResult> PJHKLPKGAMK(TRequest OHNONCFAIKH, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4D82C00", Offset = "0x4D81A00", VA = "0x184D82C00")]
	private void CKCGLGGIIMF(NPNAIMDDEEL GCGKJNMNHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4D83D50", Offset = "0x4D82B50", VA = "0x184D83D50")]
	[AsyncStateMachine(typeof(GFPGBBFBAJF<, >.OJMDGMOFJFB))]
	private Task PECONJNKNCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4D83650", Offset = "0x4D82450", VA = "0x184D83650")]
	private NPNAIMDDEEL KIEGFGEKIKE()
	{
		return default(NPNAIMDDEEL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4D83020", Offset = "0x4D81E20", VA = "0x184D83020")]
	[AsyncStateMachine(typeof(GFPGBBFBAJF<, >.PENIAPHFPCF))]
	private Task IIHGOFGNDGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4D83AC0", Offset = "0x4D828C0", VA = "0x184D83AC0")]
	private void LECGFIOODDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4D82DF0", Offset = "0x4D81BF0", VA = "0x184D82DF0", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.AppUI
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public interface IRRUISpriteLookup
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryFindSpriteByName(string spriteName, [Out] Sprite sprite);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class GKCNJIHJALJ<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly List<T> ECEBLBALENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private HashSet<T> EIBAGFGBGPI;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int OOJPJFMJCLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x43AC800", Offset = "0x43AB600", VA = "0x1843AC800", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool ECOGGGAIBMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T CBMLGEIEAGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4D9B100", Offset = "0x4D99F00", VA = "0x184D9B100", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4D9B140", Offset = "0x4D99F40", VA = "0x184D9B140", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4CFAF30", Offset = "0x4CF9D30", VA = "0x184CFAF30", Slot = "11")]
	public void Add(T EHKDLJBBGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4D9AB60", Offset = "0x4D99960", VA = "0x184D9AB60")]
	public bool POGLBLNLOIB(T EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4D9AF70", Offset = "0x4D99D70", VA = "0x184D9AF70", Slot = "15")]
	public bool Remove(T EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4D9A8C0", Offset = "0x4D996C0", VA = "0x184D9A8C0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4D53F90", Offset = "0x4D52D90", VA = "0x184D53F90", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4D9A7F0", Offset = "0x4D995F0", VA = "0x184D9A7F0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4D9A850", Offset = "0x4D99650", VA = "0x184D9A850", Slot = "13")]
	public bool Contains(T EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4D9A890", Offset = "0x4D99690", VA = "0x184D9A890", Slot = "14")]
	public void CopyTo(T[] COPOPHFGNFG, int PENDJAKLNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4D9A950", Offset = "0x4D99750", VA = "0x184D9A950", Slot = "6")]
	public int IndexOf(T EHKDLJBBGDB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4D9AA80", Offset = "0x4D99880", VA = "0x184D9AA80", Slot = "7")]
	public void Insert(int CKFKPOAGPKN, T EHKDLJBBGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4D9ACE0", Offset = "0x4D99AE0", VA = "0x184D9ACE0", Slot = "8")]
	public void RemoveAt(int CKFKPOAGPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4D9B010", Offset = "0x4D99E10", VA = "0x184D9B010")]
	public GKCNJIHJALJ()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2C42F20", Offset = "0x2C41D20", VA = "0x182C42F20")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xAB4B20", Offset = "0xAB3920", VA = "0x180AB4B20")]
		public SerializedGuid([In] Guid OKDHAOKOGCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x80827E0", Offset = "0x80815E0", VA = "0x1880827E0")]
		public static SerializedGuid JOBCJJPNBBG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8082760", Offset = "0x8081560", VA = "0x188082760")]
		public static SerializedGuid FMIBHGNJAJI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8082860", Offset = "0x8081660", VA = "0x188082860")]
		public bool NPDDCPKLJPP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8082940", Offset = "0x8081740", VA = "0x188082940", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x80828C0", Offset = "0x80816C0", VA = "0x1880828C0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8082690", Offset = "0x8081490", VA = "0x188082690", Slot = "7")]
		public bool Equals(SerializedGuid LOKLFHKEJPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x80826D0", Offset = "0x80814D0", VA = "0x1880826D0", Slot = "0")]
		public override bool Equals(object MKPNGAKJFMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x80827D0", Offset = "0x80815D0", VA = "0x1880827D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8082660", Offset = "0x8081460", VA = "0x188082660", Slot = "6")]
		public int CompareTo(SerializedGuid LOKLFHKEJPC)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class CANAJOIOCIH : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Type BLHKAACKEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly string JHIEMCFIJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly bool EENFOAFHOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly bool PPFOECGKEOH;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x807F9F0", Offset = "0x807E7F0", VA = "0x18807F9F0")]
	public CANAJOIOCIH(Type KFBIEFJCBGK, string JENALEELNGC, bool NOAFMNCHAMI = false, bool OHKBIAHHGAC = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface OABBPKOLAIF<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	int HCINEMEKDON
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<T> DLMDBLEGOJI(float GJEILCNCAPN, [Optional] float? DEPCMLAMAGM);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KIBOFKNIHLP(float GJEILCNCAPN, T BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MKDKKBLDFOH();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[Obsolete("Use ITimeSeriesRollingWindow<T> instead")]
public class ANOFICOPMAH<T> : OABBPKOLAIF<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class JPKIMJBCGPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float AKMLMBPHIAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public T HBDLGDLEPJD;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public JPKIMJBCGPJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class BHADFHJMJAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public BHADFHJMJAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6254570", Offset = "0x6253370", VA = "0x186254570")]
		internal bool IJKEIENDJIK(JPKIMJBCGPJ sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly float JHGLLGJADFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly float FPJKGGKJCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<JPKIMJBCGPJ> OPFACKLMELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private DNHHJLHCAHA<JPKIMJBCGPJ> AKGBBAMIBHE;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int HCINEMEKDON
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x50C6FF0", Offset = "0x50C5DF0", VA = "0x1850C6FF0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x50C7C10", Offset = "0x50C6A10", VA = "0x1850C7C10")]
	public ANOFICOPMAH(float DBLMIDAFICM, float KHIONDHIAAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x50C7730", Offset = "0x50C6530", VA = "0x1850C7730", Slot = "6")]
	public bool KIBOFKNIHLP(float GJEILCNCAPN, T BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x50C7400", Offset = "0x50C6200", VA = "0x1850C7400", Slot = "5")]
	public IEnumerable<T> DLMDBLEGOJI(float GJEILCNCAPN, float? DEPCMLAMAGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x50C7A40", Offset = "0x50C6840", VA = "0x1850C7A40", Slot = "7")]
	public void MKDKKBLDFOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x50C7AB0", Offset = "0x50C68B0", VA = "0x1850C7AB0")]
	private void OGOJOBPBIGP(float GJEILCNCAPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class LCGJAJKEGFO<T> : OABBPKOLAIF<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct CBMCPBMOEDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly T HBDLGDLEPJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly float AKMLMBPHIAJ;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x52DB160", Offset = "0x52D9F60", VA = "0x1852DB160")]
		public CBMCPBMOEDM(T BNECONOIKOE, float GJEILCNCAPN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class HMNPMALICEE : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public LCGJAJKEGFO<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float <>3__time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private float? minTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public float? <>3__minTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private int <count>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xF9A0D0", Offset = "0xF98ED0", VA = "0x180F9A0D0")]
		[DebuggerHidden]
		public HMNPMALICEE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x4E3BDF0", Offset = "0x4E3ABF0", VA = "0x184E3BDF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x4E3C2F0", Offset = "0x4E3B0F0", VA = "0x184E3C2F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4E3C1E0", Offset = "0x4E3AFE0", VA = "0x184E3C1E0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x4DCC5E0", Offset = "0x4DCB3E0", VA = "0x184DCC5E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly float DBLMIDAFICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly float KHIONDHIAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly List<CBMCPBMOEDM> OPFACKLMELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int HBNCFIPENFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int EDEHAFBAGBC;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int HCINEMEKDON
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA5A420", Offset = "0xA59220", VA = "0x180A5A420", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5407AB0", Offset = "0x54068B0", VA = "0x185407AB0")]
	public LCGJAJKEGFO(float DBLMIDAFICM, float KHIONDHIAAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x54075F0", Offset = "0x54063F0", VA = "0x1854075F0", Slot = "6")]
	public bool KIBOFKNIHLP(float GJEILCNCAPN, T BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x54070A0", Offset = "0x5405EA0", VA = "0x1854070A0", Slot = "8")]
	public int CKPAOBGGGIL(float GJEILCNCAPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x54070D0", Offset = "0x5405ED0", VA = "0x1854070D0", Slot = "5")]
	[IteratorStateMachine(typeof(LCGJAJKEGFO<>.HMNPMALICEE))]
	public IEnumerable<T> DLMDBLEGOJI(float GJEILCNCAPN, float? DEPCMLAMAGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5407860", Offset = "0x5406660", VA = "0x185407860", Slot = "7")]
	public void MKDKKBLDFOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5406F00", Offset = "0x5405D00", VA = "0x185406F00")]
	private void BLONKGGHAJI(float GJEILCNCAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5407230", Offset = "0x5406030", VA = "0x185407230")]
	private CBMCPBMOEDM EJMIFJCFLHP()
	{
		return default(CBMCPBMOEDM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class EHDFINDMEJI<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public readonly struct GFGCANENOAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly long JJEPBFDGPMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly long MAPGNHANOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly int EECFFNKGPNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly int APHANJCFCEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly bool HLFMEHPILDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly string NHOOPHHDJJH;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4D7FC10", Offset = "0x4D7EA10", VA = "0x184D7FC10")]
		public GFGCANENOAF(long JJEPBFDGPMF, int EECFFNKGPNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4D7FC80", Offset = "0x4D7EA80", VA = "0x184D7FC80")]
		public GFGCANENOAF(long JJEPBFDGPMF, long MAPGNHANOPN, int EECFFNKGPNK, int APHANJCFCEG, bool HLFMEHPILDP, string NHOOPHHDJJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4D7FAA0", Offset = "0x4D7E8A0", VA = "0x184D7FAA0")]
		public int BIJGNAMCMNI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4D7FB90", Offset = "0x4D7E990", VA = "0x184D7FB90")]
		public int GPAFFFILJCL(int NHBHJJOACJO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4D7FBB0", Offset = "0x4D7E9B0", VA = "0x184D7FBB0")]
		public double PFOFFONOIMK()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x4D7FAF0", Offset = "0x4D7E8F0", VA = "0x184D7FAF0")]
		public GFGCANENOAF CEDBEPJOILP(long MAPGNHANOPN, int APHANJCFCEG)
		{
			return default(GFGCANENOAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class NGEIFBMECIG : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private struct FBPEAMMJFEG<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public NGEIFBMECIG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Func<NGEIFBMECIG, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private NGEIFBMECIG <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x4C946F0", Offset = "0x4C934F0", VA = "0x184C946F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x4C94C20", Offset = "0x4C93A20", VA = "0x184C94C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly TKey PNDHCEECBFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly EHDFINDMEJI<TKey> INANPMNJHBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly PHLHEDGDBJO CFEMPAINFAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private List<NGEIFBMECIG> HMDEDHHJOKC;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string CIOOHBFLCOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x56E1960", Offset = "0x56E0760", VA = "0x1856E1960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public IEnumerable<NGEIFBMECIG> GIEBAJEANFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x56E1920", Offset = "0x56E0720", VA = "0x1856E1920")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public GFGCANENOAF LCMMCIOGLLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x56E1AF0", Offset = "0x56E08F0", VA = "0x1856E1AF0")]
			[CompilerGenerated]
			get
			{
				return default(GFGCANENOAF);
			}
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x56E18F0", Offset = "0x56E06F0", VA = "0x1856E18F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x56E1B10", Offset = "0x56E0910", VA = "0x1856E1B10")]
		internal NGEIFBMECIG(EHDFINDMEJI<TKey> INANPMNJHBH, TKey MAHBBBBCDEL, PHLHEDGDBJO CFEMPAINFAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x56E1990", Offset = "0x56E0790", VA = "0x1856E1990")]
		public NGEIFBMECIG LJGLLJIBNKD(TKey MAHBBBBCDEL, [Optional] PHLHEDGDBJO? NMGHOKJBELM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4202290", Offset = "0x4201090", VA = "0x184202290")]
		[AsyncStateMachine(typeof(FBPEAMMJFEG<>))]
		public Task<T> LCBBIGGGOIJ<T>(TKey MAHBBBBCDEL, Func<NGEIFBMECIG, Task<T>> FAMNJGOAPBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x56E16F0", Offset = "0x56E04F0", VA = "0x1856E16F0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class HFPDEGLMBNH : IEnumerable<(TKey, List<TKey>, GFGCANENOAF)>, IEnumerable, IEnumerator<(TKey, List<TKey>, GFGCANENOAF)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private (TKey key, List<TKey> path, GFGCANENOAF timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public EHDFINDMEJI<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private IEnumerator<(TKey key, List<TKey> path, GFGCANENOAF timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private (TKey, List<TKey>, GFGCANENOAF) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x2C4E210", Offset = "0x2C4D010", VA = "0x182C4E210", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, GFGCANENOAF));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x4E1FB50", Offset = "0x4E1E950", VA = "0x184E1FB50", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2C4E300", Offset = "0x2C4D100", VA = "0x182C4E300")]
		[DebuggerHidden]
		public HFPDEGLMBNH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x480A230", Offset = "0x4809030", VA = "0x18480A230", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4E1F5E0", Offset = "0x4E1E3E0", VA = "0x184E1F5E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x4E1F590", Offset = "0x4E1E390", VA = "0x184E1F590")]
		private void KHMMOEFKMMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x4E1FB00", Offset = "0x4E1E900", VA = "0x184E1FB00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x4E1FA40", Offset = "0x4E1E840", VA = "0x184E1FA40", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, GFGCANENOAF)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x43BAD20", Offset = "0x43B9B20", VA = "0x1843BAD20", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class ALNCCBCNFEH : IEnumerable<(TKey, List<TKey>, GFGCANENOAF)>, IEnumerable, IEnumerator<(TKey, List<TKey>, GFGCANENOAF)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private (TKey key, List<TKey> path, GFGCANENOAF timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private NGEIFBMECIG timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public NGEIFBMECIG <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public EHDFINDMEJI<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IEnumerator<NGEIFBMECIG> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private IEnumerator<(TKey key, List<TKey> path, GFGCANENOAF timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private (TKey, List<TKey>, GFGCANENOAF) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x2C4E210", Offset = "0x2C4D010", VA = "0x182C4E210", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, GFGCANENOAF));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x50BBA80", Offset = "0x50BA880", VA = "0x1850BBA80", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2C4E300", Offset = "0x2C4D100", VA = "0x182C4E300")]
		[DebuggerHidden]
		public ALNCCBCNFEH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x50BBAE0", Offset = "0x50BA8E0", VA = "0x1850BBAE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x50BB180", Offset = "0x50B9F80", VA = "0x1850BB180", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x50BB120", Offset = "0x50B9F20", VA = "0x1850BB120")]
		private void KHMMOEFKMMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x50BB0C0", Offset = "0x50B9EC0", VA = "0x1850BB0C0")]
		private void ICJNGMGPPIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x50BBA30", Offset = "0x50BA830", VA = "0x1850BBA30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x50BB920", Offset = "0x50BA720", VA = "0x1850BB920", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, GFGCANENOAF)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x50BBA00", Offset = "0x50BA800", VA = "0x1850BBA00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Action<TKey, GFGCANENOAF, PHLHEDGDBJO> ADLAELCCAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Action<TKey, GFGCANENOAF, PHLHEDGDBJO> KLJDEIJLGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly Action<EHDFINDMEJI<TKey>, PHLHEDGDBJO> KFFJPKAJJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly NGEIFBMECIG ELDCNNDJKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private bool FOABPIBDEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int FBNPGDPOHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Stopwatch NABDOFBDOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly int DDKFPAPFKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private string GGEPABIIKOH;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public NGEIFBMECIG CFMIIOFGNIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA59850", Offset = "0xA58650", VA = "0x180A59850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	[NotNull]
	public string CIOOHBFLCOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA5F360", Offset = "0xA5E160", VA = "0x180A5F360")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4822930", Offset = "0x4821730", VA = "0x184822930")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4822AF0", Offset = "0x48218F0", VA = "0x184822AF0")]
	public EHDFINDMEJI(TKey NOAMJGHKFMK, PHLHEDGDBJO CFEMPAINFAM, [Optional] int? EECFFNKGPNK, [Optional][CanBeNull] Stopwatch NABDOFBDOCL, [Optional] Action<TKey, GFGCANENOAF, PHLHEDGDBJO> ADLAELCCAGL, [Optional] Action<TKey, GFGCANENOAF, PHLHEDGDBJO> KLJDEIJLGFF, [Optional] Action<EHDFINDMEJI<TKey>, PHLHEDGDBJO> KFFJPKAJJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4822820", Offset = "0x4821620", VA = "0x184822820", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4822A60", Offset = "0x4821860", VA = "0x184822A60")]
	[IteratorStateMachine(typeof(EHDFINDMEJI<>.HFPDEGLMBNH))]
	public IEnumerable<(TKey, List<TKey>, GFGCANENOAF)> OBMEFGPMEDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4822990", Offset = "0x4821790", VA = "0x184822990")]
	[IteratorStateMachine(typeof(EHDFINDMEJI<>.ALNCCBCNFEH))]
	private IEnumerable<(TKey, List<TKey>, GFGCANENOAF)> OBMEFGPMEDJ(List<TKey> PFPNMKAMPMH, NGEIFBMECIG KOFEPIFFNLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x48228B0", Offset = "0x48216B0", VA = "0x1848228B0")]
	private (long, int) EMMIAMDADFI()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class OJJCECDAPMP<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut NNOEOJMMNCM(EHDFINDMEJI<TKey> INANPMNJHBH);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	protected OJJCECDAPMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class ECMAFKPBJHK<TKey> : OJJCECDAPMP<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public delegate string BLCMDHKBEBE(TKey MAHBBBBCDEL);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x480B1A0", Offset = "0x4809FA0", VA = "0x18480B1A0")]
	private static string OADOCEOALCK(TKey MAHBBBBCDEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x480B0E0", Offset = "0x4809EE0", VA = "0x18480B0E0", Slot = "4")]
	public override string NNOEOJMMNCM(EHDFINDMEJI<TKey> INANPMNJHBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x480AF90", Offset = "0x4809D90", VA = "0x18480AF90")]
	public string NNOEOJMMNCM(EHDFINDMEJI<TKey> INANPMNJHBH, [NotNull] BLCMDHKBEBE BFDALCLCPCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string IAMFKHMOBEL(EHDFINDMEJI<TKey> INANPMNJHBH, [NotNull] BLCMDHKBEBE BFDALCLCPCD);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x480B1E0", Offset = "0x4809FE0", VA = "0x18480B1E0")]
	protected ECMAFKPBJHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class NJAMHLDFCPA<TKey> : OJJCECDAPMP<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public delegate string ALLKEIEPPHD(TKey MAHBBBBCDEL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly string EPPNEIKHBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly double POBGHMDCEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly bool CDDCGKCNNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly int NPBODKJDBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly ISet<string> ADECIJNIEMP;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x56F3350", Offset = "0x56F2150", VA = "0x1856F3350")]
	private static string OADOCEOALCK(TKey MAHBBBBCDEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x56F34F0", Offset = "0x56F22F0", VA = "0x1856F34F0")]
	public NJAMHLDFCPA(string EPPNEIKHBBE = "F2", double POBGHMDCEOL = double.MaxValue, bool CDDCGKCNNNB = false, int NPBODKJDBPE = int.MaxValue, [Optional] ISet<string> ADECIJNIEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x56F3290", Offset = "0x56F2090", VA = "0x1856F3290", Slot = "4")]
	public override Dictionary<string, string> NNOEOJMMNCM(EHDFINDMEJI<TKey> INANPMNJHBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x56F2990", Offset = "0x56F1790", VA = "0x1856F2990")]
	private bool BGBLJGEIMDD(string BDLFDEHGIJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x56F2CA0", Offset = "0x56F1AA0", VA = "0x1856F2CA0")]
	public Dictionary<string, string> NNOEOJMMNCM(EHDFINDMEJI<TKey> INANPMNJHBH, ALLKEIEPPHD BFDALCLCPCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x56F2A60", Offset = "0x56F1860", VA = "0x1856F2A60")]
	private string DKKKALKFIML(StringBuilder FIDMHJHNLCG, List<TKey> FOMKJBFLKHO, ALLKEIEPPHD BFDALCLCPCD, bool DADAIFMDDMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x56F3390", Offset = "0x56F2190", VA = "0x1856F3390")]
	private static void ONAHOEKMFFA(StringBuilder FPHBDNHNFMG, string KLAOKDKFLHD, bool EENDNKJDFNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class BDCICNHCGCJ<TKey> : ECMAFKPBJHK<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct AKHOEMKEIMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public BLCMDHKBEBE keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static BDCICNHCGCJ<TKey> ODAOEPEFKDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly string[] NIAINHKLJAJ;

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6250800", Offset = "0x624F600", VA = "0x186250800")]
	private BDCICNHCGCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x624F780", Offset = "0x624E580", VA = "0x18624F780", Slot = "5")]
	protected override string IAMFKHMOBEL(EHDFINDMEJI<TKey> INANPMNJHBH, BLCMDHKBEBE BFDALCLCPCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x62505D0", Offset = "0x624F3D0", VA = "0x1862505D0")]
	[CompilerGenerated]
	internal static string OMJEHBHCJOI(string NHLAJGHCFBF, TKey MAHBBBBCDEL, AKHOEMKEIMD P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public sealed class IFNOHFAJCBB : EHDFINDMEJI<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class BDLEKGNJHJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Action<IFNOHFAJCBB, PHLHEDGDBJO> callback;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public BDLEKGNJHJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x807F810", Offset = "0x807E610", VA = "0x18807F810")]
		internal void OLGKGMHMGDB(EHDFINDMEJI<string> timer, PHLHEDGDBJO log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x80804C0", Offset = "0x807F2C0", VA = "0x1880804C0")]
	public IFNOHFAJCBB(PHLHEDGDBJO CFEMPAINFAM, [Optional] string CKAENABAGHB, [Optional] int? EECFFNKGPNK, [Optional] Stopwatch NABDOFBDOCL, [Optional] Action<string, GFGCANENOAF, PHLHEDGDBJO> ADLAELCCAGL, [Optional] Action<string, GFGCANENOAF, PHLHEDGDBJO> KLJDEIJLGFF, [Optional] Action<IFNOHFAJCBB, PHLHEDGDBJO> KFFJPKAJJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x8080400", Offset = "0x807F200", VA = "0x188080400")]
	private static Action<EHDFINDMEJI<string>, PHLHEDGDBJO> HHBKCOHCDPH(Action<IFNOHFAJCBB, PHLHEDGDBJO> JCDKDANAIEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public abstract class DCODEFOMPFG
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private class BPCDNKBAILJ : DCODEFOMPFG
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static DCODEFOMPFG ODAOEPEFKDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x807F8A0", Offset = "0x807E6A0", VA = "0x18807F8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override float OIPFLOCDEOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x130BFF0", Offset = "0x130ADF0", VA = "0x18130BFF0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x807F9A0", Offset = "0x807E7A0", VA = "0x18807F9A0")]
		public BPCDNKBAILJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static DCODEFOMPFG OAGELDDEGCM;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static DCODEFOMPFG CLGJEJAIGBE
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x807FC20", Offset = "0x807EA20", VA = "0x18807FC20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public abstract float OIPFLOCDEOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	protected DCODEFOMPFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface ECOKJONDNDB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	bool DDMFODGPIEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface NONKHMPPJIB<T> : ECOKJONDNDB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	[NotNull]
	Task<T> KDLPMCBGBMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[NotNull]
	CEBCBDBEPBJ<T> DPGHKFLKNPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class GELFOCIOHEF
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3B82120", Offset = "0x3B80F20", VA = "0x183B82120")]
	public static NONKHMPPJIB<TResource> JMPFDGPMMCF<TResource, TId>(this OKFFMCIBPAN<TId, TResource> HGDOOOHHPKA, TId PPPFBKMGIMA, [Optional] Func<TId, CancellationToken, Task<TResource>>? HEOFLENKAPP) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class BEGHKMNAOMG
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class BECDIAEBFJL<T> : NHPPAEANIOK<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<T?> KDLPMCBGBMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override CEBCBDBEPBJ<T?> DPGHKFLKNPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58660", VA = "0x180A59860", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x6252210", Offset = "0x6251010", VA = "0x186252210")]
		public BECDIAEBFJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "10")]
		protected override void IJGHMIJHLGC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class AIFCAIFJPFH<T> : NHPPAEANIOK<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly T HCJHOOFOMCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly Action<T>? CGAEFNHMPJP;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Task<T> KDLPMCBGBMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xA5C130", Offset = "0xA5AF30", VA = "0x180A5C130", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override CEBCBDBEPBJ<T> DPGHKFLKNPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0xA5C4F0", Offset = "0xA5B2F0", VA = "0x180A5C4F0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x4FE0870", Offset = "0x4FDF670", VA = "0x184FE0870")]
		public AIFCAIFJPFH(T AIAICLJOCPG, Action<T>? NDAMMPOGDLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x4FE07F0", Offset = "0x4FDF5F0", VA = "0x184FE07F0", Slot = "10")]
		protected override void IJGHMIJHLGC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private sealed class LPFHBGJJJDN<T> : NHPPAEANIOK<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override Task<T> KDLPMCBGBMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override CEBCBDBEPBJ<T> DPGHKFLKNPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58660", VA = "0x180A59860", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x548F4A0", Offset = "0x548E2A0", VA = "0x18548F4A0")]
		public LPFHBGJJJDN(Exception OLHKHMAKOHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "10")]
		protected override void IJGHMIJHLGC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private sealed class EBGHKEBJGLJ<T> : NHPPAEANIOK<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct MPENBNMHIAJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public Task<NONKHMPPJIB<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<NONKHMPPJIB<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x568B5A0", Offset = "0x568A3A0", VA = "0x18568B5A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x568BAB0", Offset = "0x568A8B0", VA = "0x18568BAB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct DAELOGFHFNL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public Task<NONKHMPPJIB<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private TaskAwaiter<NONKHMPPJIB<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x6D9A440", Offset = "0x6D99240", VA = "0x186D9A440", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x6D9A6D0", Offset = "0x6D994D0", VA = "0x186D9A6D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly Task<NONKHMPPJIB<T>> KMMPEIMFOJM;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override Task<T> KDLPMCBGBMN
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58660", VA = "0x180A59860", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override CEBCBDBEPBJ<T> DPGHKFLKNPO
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0xA59880", Offset = "0xA58680", VA = "0x180A59880", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x48004C0", Offset = "0x47FF2C0", VA = "0x1848004C0")]
		public EBGHKEBJGLJ(Task<NONKHMPPJIB<T>> JNOGJECEFDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x47FFF00", Offset = "0x47FED00", VA = "0x1847FFF00", Slot = "10")]
		protected override void IJGHMIJHLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x4800020", Offset = "0x47FEE20", VA = "0x184800020")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(EBGHKEBJGLJ<>.MPENBNMHIAJ))]
		internal static Task<T> LGLMPKLDEHC(Task<NONKHMPPJIB<T>> JNOGJECEFDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x48002E0", Offset = "0x47FF0E0", VA = "0x1848002E0")]
		[AsyncStateMachine(typeof(EBGHKEBJGLJ<>.DAELOGFHFNL))]
		[CompilerGenerated]
		internal static Task PFHBJIOOLDP(Task<NONKHMPPJIB<T>> JNOGJECEFDN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private sealed class DPPMLIAJHHJ<TIn, TOut> : NHPPAEANIOK<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct MKELCJCHFFC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public AsyncTaskMethodBuilder<TOut> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public Func<TIn, TOut> transformFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public Task<TIn> innerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private Func<TIn, TOut> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private TaskAwaiter<TIn> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x567C280", Offset = "0x567B080", VA = "0x18567C280", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x4DBC250", Offset = "0x4DBB050", VA = "0x184DBC250", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly NONKHMPPJIB<TIn> NEHADJEEHCA;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override Task<TOut> KDLPMCBGBMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58660", VA = "0x180A59860", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override CEBCBDBEPBJ<TOut> DPGHKFLKNPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xA59880", Offset = "0xA58680", VA = "0x180A59880", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6E250C0", Offset = "0x6E23EC0", VA = "0x186E250C0")]
		public DPPMLIAJHHJ(NONKHMPPJIB<TIn> MIGBOPPMNMF, Func<TIn, TOut> BBHBAINGMGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x6E25020", Offset = "0x6E23E20", VA = "0x186E25020", Slot = "10")]
		protected override void IJGHMIJHLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6E24D20", Offset = "0x6E23B20", VA = "0x186E24D20")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(DPPMLIAJHHJ<, >.MKELCJCHFFC))]
		internal static Task<TOut> EEHGJFGGCDL(Task<TIn> AJBOIAFJGMF, Func<TIn, TOut> BBHBAINGMGJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x39347F0", Offset = "0x39335F0", VA = "0x1839347F0")]
	public static NONKHMPPJIB<T> MMHNBCKELFI<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3934760", Offset = "0x3933560", VA = "0x183934760")]
	public static NONKHMPPJIB<T> JCJLJPEJCED<T>(T OHLBIIOAJDL, [Optional] Action<T>? NDAMMPOGDLL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3122F60", Offset = "0x3121D60", VA = "0x183122F60")]
	public static NONKHMPPJIB<T> CEAIDKBCDLH<T>(Exception OLHKHMAKOHL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3122F60", Offset = "0x3121D60", VA = "0x183122F60")]
	public static NONKHMPPJIB<T> BEFKALEBMFB<T>(Task<NONKHMPPJIB<T>> JNOGJECEFDN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x311BE10", Offset = "0x311AC10", VA = "0x18311BE10")]
	public static NONKHMPPJIB<TOut> HBAFPBAGLCP<TOut, TIn>(NONKHMPPJIB<TIn> DADONNGONOC, Func<TIn, TOut> BBHBAINGMGJ) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class NHPPAEANIOK<T> : NONKHMPPJIB<T>, ECOKJONDNDB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly string EDOEIDFEKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly CADHCNHOMBK LHGNFGCKPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private bool FOABPIBDEDN;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool DDMFODGPIEN
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xB2CE50", Offset = "0xB2BC50", VA = "0x180B2CE50", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public abstract Task<T> KDLPMCBGBMN
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public abstract CEBCBDBEPBJ<T> DPGHKFLKNPO
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x56ED2B0", Offset = "0x56EC0B0", VA = "0x1856ED2B0")]
	public NHPPAEANIOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x56ECFF0", Offset = "0x56EBDF0", VA = "0x1856ECFF0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void IJGHMIJHLGC();
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public abstract class PNPGDGKPOAD<TTask, T> : NHPPAEANIOK<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class JEAALDECDHB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public JEAALDECDHB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x43944B0", Offset = "0x43932B0", VA = "0x1843944B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x4394A20", Offset = "0x4393820", VA = "0x184394A20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public PNPGDGKPOAD<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public JEAALDECDHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x5191600", Offset = "0x5190400", VA = "0x185191600")]
		[AsyncStateMachine(typeof(PNPGDGKPOAD<, >.JEAALDECDHB.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> BHKAIECOMLC(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Task<T> JNOGJECEFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	protected readonly CancellationTokenSource JJKKCMEFGAC;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public override Task<T> KDLPMCBGBMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public override CEBCBDBEPBJ<T> DPGHKFLKNPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58660", VA = "0x180A59860", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x59CF0C0", Offset = "0x59CDEC0", VA = "0x1859CF0C0")]
	protected PNPGDGKPOAD(TTask JNOGJECEFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x59CEEA0", Offset = "0x59CDCA0", VA = "0x1859CEEA0", Slot = "10")]
	protected override void IJGHMIJHLGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T HONOJPILCNC(TTask EDJHELAPGNK);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void PIMJEPFJMIL();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class HBNIEKPDHEK<T> : NHPPAEANIOK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly BFMFPOLFIAF<Task<T>> AFBMJCJAIFC;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override Task<T> KDLPMCBGBMN
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x4E12F00", Offset = "0x4E11D00", VA = "0x184E12F00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override CEBCBDBEPBJ<T> DPGHKFLKNPO
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58660", VA = "0x180A59860", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x4E12F60", Offset = "0x4E11D60", VA = "0x184E12F60")]
	public HBNIEKPDHEK(BFMFPOLFIAF<Task<T>> NEMOIHHHEBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x4E12F40", Offset = "0x4E11D40", VA = "0x184E12F40", Slot = "10")]
	protected override void IJGHMIJHLGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class IKNNGDINJCO
{
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly HashAlgorithmName BPGBEOABDNB;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly ThreadLocal<IncrementalHash> JOCOMBHFKFN;

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x8080CC0", Offset = "0x807FAC0", VA = "0x188080CC0")]
	public static int MKNDKJBOFDL(this JLNNICPJFOO PMLDDHJDCGA, IncrementalHash MOOBNHLGDMK, byte[] GAHOEHCJLAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x8080920", Offset = "0x807F720", VA = "0x188080920")]
	public static bool DLMKMNLGKPL([CanBeNull] this JLNNICPJFOO PMLDDHJDCGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x8080610", Offset = "0x807F410", VA = "0x188080610")]
	public static bool DLMKMNLGKPL([CanBeNull] this JLNNICPJFOO PMLDDHJDCGA, [Out] string BKBLOMKNEFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x8080980", Offset = "0x807F780", VA = "0x188080980")]
	public static bool DLMKMNLGKPL([CanBeNull] this JLNNICPJFOO PMLDDHJDCGA, IncrementalHash MOOBNHLGDMK, byte[] GAHOEHCJLAL, [Out] string BKBLOMKNEFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x8080D50", Offset = "0x807FB50", VA = "0x188080D50")]
	private static bool OABALBNKOBF(byte[] FJHOANAHFPA, Span<byte> HCNBMHLIDBN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class ALFGPBDJOGF
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x807F5D0", Offset = "0x807E3D0", VA = "0x18807F5D0")]
	public static int FLICGJPCPCA(HashAlgorithmName JLBNDPAEJJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x311C6B0", Offset = "0x311B4B0", VA = "0x18311C6B0")]
	public static int MKNDKJBOFDL<T>(this T BGALILGMCPL, byte[] PKBHJGKCHFA, IncrementalHash MOOBNHLGDMK, byte[] EINDKFLHHMM) where T : EKNKHLNLFEE
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface EKNKHLNLFEE
{
	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash MOOBNHLGDMK);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface JLNNICPJFOO : EKNKHLNLFEE
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	[CanBeNull]
	byte[] PHENCEEIHHB
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	[CanBeNull]
	byte[] CCFICBDNEGP
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class AAELFGGCPGN
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static bool LIGALDDNOLI;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly ArrayPool<byte> CCPAJEFABGM;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly ArrayPool<char> DAICDKGMOIF;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly Encoding BPALMHIHGMI;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly ThreadLocal<Encoder> IMADICIHOFD;

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x31140E0", Offset = "0x3112EE0", VA = "0x1831140E0")]
	public static void MIKBJIJKBBJ<T>(this IncrementalHash ACMNPPKDJEJ, [CanBeNull] T LPAADBJGJNL) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3112ED0", Offset = "0x3111CD0", VA = "0x183112ED0")]
	public static void CKIIEBOEDFB<T>(this IncrementalHash ACMNPPKDJEJ, [CanBeNull] T BGALILGMCPL) where T : EKNKHLNLFEE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x3113BC0", Offset = "0x31129C0", VA = "0x183113BC0")]
	public static void KHPILOEHJLL<T>(this IncrementalHash ACMNPPKDJEJ, [CanBeNull] IList<T> JIBEFMIHIKH) where T : EKNKHLNLFEE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x807E7B0", Offset = "0x807D5B0", VA = "0x18807E7B0")]
	private static bool HDNIKKJKCOM([CanBeNull] EKNKHLNLFEE BGALILGMCPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x807E840", Offset = "0x807D640", VA = "0x18807E840")]
	public static void ILIFDHHDCEH(this IncrementalHash MOOBNHLGDMK, string? OPJCMMBJAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x807ECB0", Offset = "0x807DAB0", VA = "0x18807ECB0")]
	public static void KJPIOAHIFIE(this IncrementalHash MOOBNHLGDMK, long JMCCGLPMOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x807E520", Offset = "0x807D320", VA = "0x18807E520")]
	public static void CJAIACCGGIA(this IncrementalHash MOOBNHLGDMK, int NNJILDOHBGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x807EEE0", Offset = "0x807DCE0", VA = "0x18807EEE0")]
	public static void NFBHFFOFMPG(this IncrementalHash MOOBNHLGDMK, short BBMGFALONML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x807F0B0", Offset = "0x807DEB0", VA = "0x18807F0B0")]
	public static void NGLGHJKABGC(this IncrementalHash MOOBNHLGDMK, byte LEJLIJJDELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x807F1C0", Offset = "0x807DFC0", VA = "0x18807F1C0")]
	public static void OAFJBDCJPKH(this IncrementalHash MOOBNHLGDMK, bool IIGFMDJKJCG, bool AKADONFNLBE = false, bool BMFIBBFGEKJ = false, bool GLDEDODJGOK = false, bool OLJBNOBILBM = false, bool FAKAMMIHBFC = false, bool IHEFOHKCLPM = false, bool BDHDFMGOBDG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x3112F60", Offset = "0x3111D60", VA = "0x183112F60")]
	public static void FEOCNKIFNBA<T>(this IncrementalHash MOOBNHLGDMK, T HECBCEDKAOK) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x807EE80", Offset = "0x807DC80", VA = "0x18807EE80")]
	public static void LKKEHNMNLIF(this IncrementalHash MOOBNHLGDMK, float HAFMFGFGGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x807E6F0", Offset = "0x807D4F0", VA = "0x18807E6F0")]
	public static void DMPNOFEKDJP(this IncrementalHash MOOBNHLGDMK, ulong OMCGGNHNODP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x807EC50", Offset = "0x807DA50", VA = "0x18807EC50")]
	public static void JPJICBIPKHM(this IncrementalHash MOOBNHLGDMK, uint GKEFEBEANEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x807E750", Offset = "0x807D550", VA = "0x18807E750")]
	public static void EKBOBKMOHLB(this IncrementalHash MOOBNHLGDMK, ushort LOGDCHMENPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x807E3F0", Offset = "0x807D1F0", VA = "0x18807E3F0")]
	public static void BIKCBNPKBGO(this IncrementalHash MOOBNHLGDMK, Vector3 IGDBGCBPFFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class LNEGJKKDFIA : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x8081080", Offset = "0x807FE80", VA = "0x188081080")]
	public LNEGJKKDFIA(string IIHOFBLPONF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class JPPBOKFKBGP
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate void NOPMOPCDNIP(ushort BFMHPNMOEBM, ushort JGCGFOCBBHD, ushort EDOLEGPEDPF, ushort FBOFCMHLHDH);

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate void AOPHDBLNGOG(ushort GOOMCCDBDDI, ushort AENHKICHKBO);

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public delegate void NDNLBHMKGFN();

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const ushort ICOFOFOCOGM = ushort.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	protected JPPBOKFKBGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class GPCJJKOGKHJ<T> : JPPBOKFKBGP where T : GPCJJKOGKHJ<T>.HIEHHJMIEJJ
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public interface HIEHHJMIEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		AOPHDBLNGOG EHOECOGJLLD
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		AOPHDBLNGOG IPJNJPFPKDE
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		NDNLBHMKGFN JFDNODEGDMG
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Dictionary<uint, T> GALAKGBIBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private NDNLBHMKGFN GPEANIMPDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private NDNLBHMKGFN APCNGBLJOLD;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool PCMIDMMJKGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xAAA5A0", Offset = "0xAA93A0", VA = "0x180AAA5A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA5AE90", Offset = "0xA59C90", VA = "0x180A5AE90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public ushort BHHNIJIMNEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x11DF610", Offset = "0x11DE410", VA = "0x1811DF610")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x11DF710", Offset = "0x11DE510", VA = "0x1811DF710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public ushort GFBKAAKMKML
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x4DD6CE0", Offset = "0x4DD5AE0", VA = "0x184DD6CE0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4DD74E0", Offset = "0x4DD62E0", VA = "0x184DD74E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public ushort OHELLDEACJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xEFA580", Offset = "0xEF9380", VA = "0x180EFA580")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xEFA6A0", Offset = "0xEF94A0", VA = "0x180EFA6A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public ushort BGKGNFIHFIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x4DD6D40", Offset = "0x4DD5B40", VA = "0x184DD6D40")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x4DD6840", Offset = "0x4DD5640", VA = "0x184DD6840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	protected bool EJPENLPBNBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x11DF290", Offset = "0x11DE090", VA = "0x1811DF290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected bool NLGILPKFLBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xFD7B50", Offset = "0xFD6950", VA = "0x180FD7B50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event NOPMOPCDNIP GBDGFCBNNDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4DD67A0", Offset = "0x4DD55A0", VA = "0x184DD67A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4DD75B0", Offset = "0x4DD63B0", VA = "0x184DD75B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x4DD7520", Offset = "0x4DD6320", VA = "0x184DD7520")]
	private T MPEKJHCJEBM(ushort JAEACOFJMKH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x4DD6850", Offset = "0x4DD5650", VA = "0x184DD6850")]
	private T EPEEAGPEAAC(ushort JAEACOFJMKH, ushort GPBEHDKFEFC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x4DD6CF0", Offset = "0x4DD5AF0", VA = "0x184DD6CF0")]
	protected T ICKHFACHONI(uint OBCKJCDFDAM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x4DD7660", Offset = "0x4DD6460", VA = "0x184DD7660")]
	protected GPCJJKOGKHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x4DD6930", Offset = "0x4DD5730", VA = "0x184DD6930")]
	public void GGJHBADPIOP(ushort FDMNDIAEHOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x4DD68E0", Offset = "0x4DD56E0", VA = "0x184DD68E0")]
	public void GGJHBADPIOP(ushort FDMNDIAEHOL, ushort CCCGBBGLCNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x4DD6950", Offset = "0x4DD5750", VA = "0x184DD6950", Slot = "4")]
	protected virtual void GGJHBADPIOP(uint FIJBEAHIMNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x4DD6D60", Offset = "0x4DD5B60", VA = "0x184DD6D60")]
	protected void JEIBFMOOBPD(uint FIJBEAHIMNM, uint KNEPNLBHPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x4DD6A20", Offset = "0x4DD5820", VA = "0x184DD6A20")]
	protected void GJKMLEDJCJM(ushort JAEACOFJMKH, ushort GPBEHDKFEFC, T EOMNODKHFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x4DD74F0", Offset = "0x4DD62F0", VA = "0x184DD74F0")]
	private void KPCEHKDEEFH(uint OBCKJCDFDAM, T EOMNODKHFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x4DD6A90", Offset = "0x4DD5890", VA = "0x184DD6A90")]
	protected void GLGIIJMNIPL(float GJELOGAKDKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x4DD6790", Offset = "0x4DD5590", VA = "0x184DD6790")]
	protected uint BMEALBNMMNK(ushort JAEACOFJMKH, ushort GPBEHDKFEFC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x4DD6D50", Offset = "0x4DD5B50", VA = "0x184DD6D50")]
	protected ushort JCMIDFMBPHO(uint HDLBKJBFEMA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x4DD7650", Offset = "0x4DD6450", VA = "0x184DD7650")]
	protected ushort OHKANPILIPH(uint HDLBKJBFEMA)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class HHHOHIFFMKP : GPCJJKOGKHJ<HHHOHIFFMKP.HNLOMKFHBON>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class HNLOMKFHBON : HIEHHJMIEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public AOPHDBLNGOG EHOECOGJLLD
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0xA59840", Offset = "0xA58640", VA = "0x180A59840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public AOPHDBLNGOG IPJNJPFPKDE
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xA595A0", Offset = "0xA583A0", VA = "0x180A595A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public NDNLBHMKGFN JFDNODEGDMG
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58660", VA = "0x180A59860", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xA595B0", Offset = "0xA583B0", VA = "0x180A595B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public HNLOMKFHBON()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x807FF40", Offset = "0x807ED40", VA = "0x18807FF40")]
	public void GPNMEHFFOCI(ushort KGHMKFOEHOL, AOPHDBLNGOG IDNFJPEIFOG, AOPHDBLNGOG BEPKGPPPBEE, NDNLBHMKGFN PKCHEAFKHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x807FE60", Offset = "0x807EC60", VA = "0x18807FE60")]
	public void GPNMEHFFOCI(ushort JAEACOFJMKH, ushort GPBEHDKFEFC, AOPHDBLNGOG IDNFJPEIFOG, AOPHDBLNGOG BEPKGPPPBEE, NDNLBHMKGFN PKCHEAFKHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x807FE10", Offset = "0x807EC10", VA = "0x18807FE10")]
	public void FLCGEBIGNJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x8080020", Offset = "0x807EE20", VA = "0x188080020")]
	protected HHHOHIFFMKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class HJDFGFBBPBO : HHHOHIFFMKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private bool KHGNHKGFOLO;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool LJEKCHIHJOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xD238E0", Offset = "0xD226E0", VA = "0x180D238E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xDD6110", Offset = "0xDD4F10", VA = "0x180DD6110")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x8080060", Offset = "0x807EE60", VA = "0x188080060")]
	public void DGPDNICIDDD(ushort ODCNJLPBADF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x80800C0", Offset = "0x807EEC0", VA = "0x1880800C0")]
	public void DGPDNICIDDD(ushort ODCNJLPBADF, ushort NBAOHAKNAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x8080020", Offset = "0x807EE20", VA = "0x188080020")]
	public HJDFGFBBPBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class GJGFNCFICJD<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal class HNIBLIEIDCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public TNode FEOFEEGOGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public TNode CMDMCJGFCDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public PHIBGMGBBDB PBHKHJPMFCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public List<PHIBGMGBBDB> FMCAMMBHBDI;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public HNIBLIEIDCD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal struct PHIBGMGBBDB : IComparable<PHIBGMGBBDB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int HNGPPDLEICO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public TClaimant FPFOGGLGFNI;

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x1860240", Offset = "0x185F040", VA = "0x181860240")]
		public PHIBGMGBBDB(int HNGPPDLEICO, TClaimant FPFOGGLGFNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x598AFB0", Offset = "0x5989DB0", VA = "0x18598AFB0")]
		public bool KFDMIPIFADM([In] PHIBGMGBBDB LOKLFHKEJPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x598B010", Offset = "0x5989E10", VA = "0x18598B010")]
		public bool MFHDJNEGKNP([In] PHIBGMGBBDB LOKLFHKEJPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x598AFA0", Offset = "0x5989DA0", VA = "0x18598AFA0", Slot = "4")]
		public int CompareTo(PHIBGMGBBDB LOKLFHKEJPC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x598B020", Offset = "0x5989E20", VA = "0x18598B020", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public enum COCJFMNHPKB
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class HNHKHLMFKFG : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public GJGFNCFICJD<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xF9A0D0", Offset = "0xF98ED0", VA = "0x180F9A0D0")]
		[DebuggerHidden]
		public HNHKHLMFKFG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x4E3E790", Offset = "0x4E3D590", VA = "0x184E3E790", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x4E3E950", Offset = "0x4E3D750", VA = "0x184E3E950", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x4E3E870", Offset = "0x4E3D670", VA = "0x184E3E870", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x4C8E770", Offset = "0x4C8D570", VA = "0x184C8E770", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly DNHHJLHCAHA<HNIBLIEIDCD> ENIPIBNANOM;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly DNHHJLHCAHA<List<PHIBGMGBBDB>> NFNNANIAOGB;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static int CNHMEMACEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	internal readonly Dictionary<TClaimant, TNode> MOFOCDFOGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	internal readonly Dictionary<TNode, HNIBLIEIDCD> MHMAMFJFJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private COCJFMNHPKB ICPOMAFNIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool HDGGIMAAJCJ;

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode AEBFDDKIMKJ(TNode FNINGPDJHMC);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void BAAHKDHIDNM(TNode FNINGPDJHMC, TClaimant AJLKKMBPOPE, TClaimant PECNGGGEHEH);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x4D96C30", Offset = "0x4D95A30", VA = "0x184D96C30")]
	public GJGFNCFICJD(COCJFMNHPKB ICPOMAFNIKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x4D95630", Offset = "0x4D94430", VA = "0x184D95630")]
	public void EEMPJEAJNIF(TNode FNINGPDJHMC, TNode HCGMLNGABFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x4D95890", Offset = "0x4D94690", VA = "0x184D95890")]
	public void HMLOJDAHAJP(TClaimant FPFOGGLGFNI, TNode PMPEPJEKMIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x4D95460", Offset = "0x4D94260", VA = "0x184D95460", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x4D96410", Offset = "0x4D95210", VA = "0x184D96410")]
	private void LMKNMBDCIKI(TClaimant FPFOGGLGFNI, TNode GIMJFIMOOBB, TNode PMPEPJEKMIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x4D953F0", Offset = "0x4D941F0", VA = "0x184D953F0")]
	private int DABCBBILBIO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x4D96730", Offset = "0x4D95530", VA = "0x184D96730")]
	private void OKDLHCBFEPJ(TClaimant FPFOGGLGFNI, TNode BOGJPGILCEK, TNode NLIKAMKMMLM, int OJGDMKBMPPO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x4D96380", Offset = "0x4D95180", VA = "0x184D96380")]
	private void LCCCMDDIFOO(PHIBGMGBBDB OFEHIFBEFBD, HNIBLIEIDCD JCEFHNCIHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x4D95BD0", Offset = "0x4D949D0", VA = "0x184D95BD0")]
	private void JBFJMFMMDBD(TClaimant FPFOGGLGFNI, TNode BOGJPGILCEK, TNode NLIKAMKMMLM, int OJGDMKBMPPO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x4D964B0", Offset = "0x4D952B0", VA = "0x184D964B0")]
	private void LODLOCHODNE(PHIBGMGBBDB OFEHIFBEFBD, TNode FNINGPDJHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x4D956C0", Offset = "0x4D944C0", VA = "0x184D956C0")]
	private void FGPOJDNDMKK(PHIBGMGBBDB OFEHIFBEFBD, HNIBLIEIDCD JCEFHNCIHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x4D959B0", Offset = "0x4D947B0", VA = "0x184D959B0")]
	private void IBNMFDJEIDP(HNIBLIEIDCD JCEFHNCIHBC, bool HDDEBELKJJE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x4D95EB0", Offset = "0x4D94CB0", VA = "0x184D95EB0")]
	private void JMOHANKLEGL(HNIBLIEIDCD JCEFHNCIHBC, TNode HCGMLNGABFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x4D957B0", Offset = "0x4D945B0", VA = "0x184D957B0")]
	[IteratorStateMachine(typeof(GJGFNCFICJD<, >.HNHKHLMFKFG))]
	private IEnumerable<TNode> GPJLAKBKLNF(TNode BOGJPGILCEK, TNode NLIKAMKMMLM, bool OEIAHFKOFAM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x4D95AE0", Offset = "0x4D948E0", VA = "0x184D95AE0")]
	private HNIBLIEIDCD IIBIJFOEINH(TNode FNINGPDJHMC, TNode CMDMCJGFCDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x4D96210", Offset = "0x4D95010", VA = "0x184D96210")]
	private HNIBLIEIDCD JNJPCCILHAJ(TNode FNINGPDJHMC, TNode CMDMCJGFCDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x4D965C0", Offset = "0x4D953C0", VA = "0x184D965C0")]
	private void LPHGBELOFKO(HNIBLIEIDCD JCEFHNCIHBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class JIBIHOOHDMH<T> : IEnumerable<JIBIHOOHDMH<T>.POFJOIHJIMH>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public struct POFJOIHJIMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public T BNECONOIKOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public int CKFKPOAGPKN;
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class KOMAALLJCLL : IEnumerator<POFJOIHJIMH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private JIBIHOOHDMH<T> NGHKKFKEBOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int CKFKPOAGPKN;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x484AA90", Offset = "0x4849890", VA = "0x18484AA90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public POFJOIHJIMH BNFIAAPBEMM
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x52F4F90", Offset = "0x52F3D90", VA = "0x1852F4F90", Slot = "4")]
			get
			{
				return default(POFJOIHJIMH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x52F4EA0", Offset = "0x52F3CA0", VA = "0x1852F4EA0")]
		public KOMAALLJCLL(JIBIHOOHDMH<T> NGHKKFKEBOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x52F4E20", Offset = "0x52F3C20", VA = "0x1852F4E20", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x48B0490", Offset = "0x48AF290", VA = "0x1848B0490", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x128F760", Offset = "0x128E560", VA = "0x18128F760", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private struct PKADPFLMCNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public bool IADJHKBOJFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public T BNECONOIKOE;
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private const int NPCJHLBGGNM = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly Dictionary<T, int> CNJCCBJKKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private PKADPFLMCNG[] GLOJMEKJLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int LBCLKKJKJAP;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int BPNINBPHLLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xABC820", Offset = "0xABB620", VA = "0x180ABC820")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xFF7DA0", Offset = "0xFF6BA0", VA = "0x180FF7DA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int OOJPJFMJCLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x43AC800", Offset = "0x43AB600", VA = "0x1843AC800")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x51AFE00", Offset = "0x51AEC00", VA = "0x1851AFE00")]
	public JIBIHOOHDMH(int COJMCLGONLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x51AF660", Offset = "0x51AE460", VA = "0x1851AF660")]
	public JIBIHOOHDMH(POFJOIHJIMH[] JJIAGGBMFIJ, bool GAJAHMJEGMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x51AEE80", Offset = "0x51ADC80", VA = "0x1851AEE80")]
	public int FLGHCDJIINJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x51AE900", Offset = "0x51AD700", VA = "0x1851AE900")]
	private int ALIPOIAINOG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x51AF0A0", Offset = "0x51ADEA0", VA = "0x1851AF0A0", Slot = "6")]
	protected virtual uint PBAJPMMBLLP(uint MOOBNHLGDMK, T BNECONOIKOE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x51AEFD0", Offset = "0x51ADDD0", VA = "0x1851AEFD0")]
	public bool HDGPHFFFDLN(T BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x51AEE10", Offset = "0x51ADC10", VA = "0x1851AEE10")]
	public int FLFMKFPMILI(T BNECONOIKOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x51AEF10", Offset = "0x51ADD10", VA = "0x1851AEF10")]
	public T GGDBPONNJMM(int CKFKPOAGPKN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x51AF2E0", Offset = "0x51AE0E0", VA = "0x1851AF2E0")]
	public bool POGLBLNLOIB(T BNECONOIKOE, bool JOJCKOOFDOK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x51AF0D0", Offset = "0x51ADED0", VA = "0x1851AF0D0")]
	public bool POGLBLNLOIB(T BNECONOIKOE, int CKFKPOAGPKN, bool JOJCKOOFDOK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x51AED10", Offset = "0x51ADB10", VA = "0x1851AED10")]
	private int DJCGEKFCHLF(int HBNCFIPENFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x51AF5E0", Offset = "0x51AE3E0", VA = "0x1851AF5E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x51AF5E0", Offset = "0x51AE3E0", VA = "0x1851AF5E0", Slot = "4")]
	private IEnumerator<POFJOIHJIMH> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class DNHHJLHCAHA<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly Stack<T> DLFKJJNLNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly List<T> AJPGHPKEEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly int DKFANAOICHO;

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6E1C0B0", Offset = "0x6E1AEB0", VA = "0x186E1C0B0")]
	public static DNHHJLHCAHA<T> GJCCMGLFILK(int COJMCLGONLG = 0, int DKFANAOICHO = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6E1C190", Offset = "0x6E1AF90", VA = "0x186E1C190")]
	public static DNHHJLHCAHA<T> LMPANHNKANC(int COJMCLGONLG = 0, int DKFANAOICHO = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6E1C350", Offset = "0x6E1B150", VA = "0x186E1C350")]
	public DNHHJLHCAHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6E1C380", Offset = "0x6E1B180", VA = "0x186E1C380")]
	public DNHHJLHCAHA(int COJMCLGONLG, int DKFANAOICHO = int.MaxValue, bool JDLMAKOLPHB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6E1BAE0", Offset = "0x6E1A8E0", VA = "0x186E1BAE0")]
	public T AOBILGBCGBI()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6E1C270", Offset = "0x6E1B070", VA = "0x186E1C270")]
	public void NIADOCPAAKN(T BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6E1BC80", Offset = "0x6E1AA80", VA = "0x186E1BC80")]
	private void CAHLLAPHJIC(T BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6E1BAC0", Offset = "0x6E1A8C0", VA = "0x186E1BAC0")]
	private void AFLMJJGDIBG(T BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6E1BF60", Offset = "0x6E1AD60", VA = "0x186E1BF60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x6E1BD60", Offset = "0x6E1AB60", VA = "0x186E1BD60")]
	private void CHOHOEPKNIO(IEnumerable<T> FEBLBJIINOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class EJGOCLENNHL<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private Dictionary<int, T> OBJPMEDBNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private T GPLMGMGJPBG;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public virtual T BIAGEMBCPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xA595A0", Offset = "0xA583A0", VA = "0x180A595A0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x4829E30", Offset = "0x4828C30", VA = "0x184829E30")]
	public bool GDOMOJLGIKD(T BNECONOIKOE, int HNGPPDLEICO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x4829D50", Offset = "0x4828B50", VA = "0x184829D50")]
	public bool FGGHDPDBNDA(int HNGPPDLEICO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x4829EB0", Offset = "0x4828CB0", VA = "0x184829EB0")]
	public T KHHFAKHKODJ(int MCDBABCFADK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x4829B10", Offset = "0x4828910", VA = "0x184829B10")]
	private bool ADOFFDCCLFK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x4829D00", Offset = "0x4828B00", VA = "0x184829D00")]
	public bool BNILIKGEJAF(int HNGPPDLEICO, [Out] T BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x482A2C0", Offset = "0x48290C0", VA = "0x18482A2C0")]
	public EJGOCLENNHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class KGJPNKMDMKD<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	protected struct HJGIIOADPCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public T HBDLGDLEPJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int CDCBBIHPMMN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	protected readonly List<HJGIIOADPCC> DFNCBGDAHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private T DLNGAKGLCNI;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public int OOJPJFMJCLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x43AC800", Offset = "0x43AB600", VA = "0x1843AC800")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x52CC8B0", Offset = "0x52CB6B0", VA = "0x1852CC8B0")]
	public bool CGCEPCBCCPD(T BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x52CD3B0", Offset = "0x52CC1B0", VA = "0x1852CD3B0")]
	public void OLHPIGGMIDE(T BNECONOIKOE, int HNGPPDLEICO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x52CCDE0", Offset = "0x52CBBE0", VA = "0x1852CCDE0")]
	public bool EBNLHEFHMEO(T BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x52CD2B0", Offset = "0x52CC0B0", VA = "0x1852CD2B0")]
	public void MKDKKBLDFOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x52CC810", Offset = "0x52CB610", VA = "0x1852CC810")]
	public T AIMBEFNAALB()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x52CD120", Offset = "0x52CBF20", VA = "0x1852CD120")]
	protected void HNGAKKGMPGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x52CD430", Offset = "0x52CC230", VA = "0x1852CD430")]
	public KGJPNKMDMKD()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[LHHMDDGFBKD(NKIOFDIBBLL.Self, false, false, false)]
		[SerializeField]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x8081390", Offset = "0x8080190", VA = "0x188081390")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x8081660", Offset = "0x8080460", VA = "0x188081660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x8081570", Offset = "0x8080370", VA = "0x188081570")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x80812E0", Offset = "0x80800E0", VA = "0x1880812E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x80815B0", Offset = "0x80803B0", VA = "0x1880815B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x80814C0", Offset = "0x80802C0", VA = "0x1880814C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8081250", Offset = "0x8080050", VA = "0x188081250")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x5BA6710", Offset = "0x5BA5510", VA = "0x185BA6710", Slot = "4")]
		public virtual T EBGNHCGKIHO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface ABMOEAHAFFE
{
	[Cpp2IlInjected.Token(Token = "0x17000070")]
	ToolHierarchyCache BGLDAMDKDJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		public struct LJDNJBGONOM<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			private readonly List<Component> ECEBLBALENP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			private readonly bool ONHECMHAEGN;

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x19D5B50", Offset = "0x19D4950", VA = "0x1819D5B50")]
			public LJDNJBGONOM(List<Component> ECEBLBALENP, bool ONHECMHAEGN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x547F3C0", Offset = "0x547E1C0", VA = "0x18547F3C0")]
			public IJKDBDEKKJK<T> OMGGHMFPBJO()
			{
				return default(IJKDBDEKKJK<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x547F430", Offset = "0x547E230", VA = "0x18547F430", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x547F430", Offset = "0x547E230", VA = "0x18547F430", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000079")]
		public struct IJKDBDEKKJK<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private readonly List<Component> ECEBLBALENP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			private readonly bool ONHECMHAEGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			private int CKFKPOAGPKN;

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public T BNFIAAPBEMM
			{
				[Cpp2IlInjected.Token(Token = "0x6000248")]
				[Cpp2IlInjected.Address(RVA = "0x4F22DA0", Offset = "0x4F21BA0", VA = "0x184F22DA0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000249")]
				[Cpp2IlInjected.Address(RVA = "0x4F22D30", Offset = "0x4F21B30", VA = "0x184F22D30", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x4F22D70", Offset = "0x4F21B70", VA = "0x184F22D70")]
			public IJKDBDEKKJK(List<Component> ECEBLBALENP, bool ONHECMHAEGN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x4F22C70", Offset = "0x4F21A70", VA = "0x184F22C70", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x4F22C80", Offset = "0x4F21A80", VA = "0x184F22C80", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x489ECB0", Offset = "0x489DAB0", VA = "0x18489ECB0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x8083090", Offset = "0x8081E90", VA = "0x188083090")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x8082980", Offset = "0x8081780", VA = "0x188082980")]
		private void DGPDNICIDDD(GameObject EJNHDGCJKPM, bool ADJOPEHJOFG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x8082AF0", Offset = "0x80818F0", VA = "0x188082AF0")]
		public static void DGPDNICIDDD(GameObject EJNHDGCJKPM, ToolHierarchyCache HGDOOOHHPKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x8082970", Offset = "0x8081770", VA = "0x188082970")]
		public void AKHKEEOJDLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3F466A0", Offset = "0x3F454A0", VA = "0x183F466A0")]
		public void FGBBCLDEGCK<T>(Action<T> LJIGAFKJJAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x3F468C0", Offset = "0x3F456C0", VA = "0x183F468C0")]
		public T JKGJJNNHHHJ<T>(bool ONHECMHAEGN = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x3F46930", Offset = "0x3F45730", VA = "0x183F46930")]
		public LJDNJBGONOM<T> KFOGFNJOCJN<T>(bool ONHECMHAEGN = false) where T : class
		{
			return default(LJDNJBGONOM<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8082C70", Offset = "0x8081A70", VA = "0x188082C70")]
		public List<Component> JBCOBJIKMJM(Type DGPNPBEKOOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8082B80", Offset = "0x8081980", VA = "0x188082B80", Slot = "4")]
		public bool Equals(ToolHierarchyCache DHOMBGCEEAK, ToolHierarchyCache EDBCCDDDLPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8082C00", Offset = "0x8081A00", VA = "0x188082C00", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache MKPNGAKJFMP)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class AODDNCGCEPP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private int COJMCLGONLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private int AHAHICEAAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private List<T> GAMMEDAFION;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int OOJPJFMJCLH
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x4E12F00", Offset = "0x4E11D00", VA = "0x184E12F00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public T CPHACEBIHDG
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x50C8B60", Offset = "0x50C7960", VA = "0x1850C8B60")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public T LMPJECOCHGG
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x50C8D90", Offset = "0x50C7B90", VA = "0x1850C8D90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public T DFGAMDGGPGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x50C8A50", Offset = "0x50C7850", VA = "0x1850C8A50")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x50C9020", Offset = "0x50C7E20", VA = "0x1850C9020")]
	public AODDNCGCEPP(int COJMCLGONLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x50C8F10", Offset = "0x50C7D10", VA = "0x1850C8F10")]
	public void OLHPIGGMIDE(T PPLADPBMPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x50C8CF0", Offset = "0x50C7AF0", VA = "0x1850C8CF0")]
	public void MKDKKBLDFOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x50C88B0", Offset = "0x50C76B0", VA = "0x1850C88B0")]
	public void AJDKCGMECDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x50C8990", Offset = "0x50C7790", VA = "0x1850C8990")]
	public void HJHDNECHCJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x50C8980", Offset = "0x50C7780", VA = "0x1850C8980")]
	public void FHGGECCDPKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x50C8AE0", Offset = "0x50C78E0", VA = "0x1850C8AE0")]
	public List<T> KIIBJGEGGJN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class DDCPOGLAFMM<T>
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private struct PPPDJIKPDIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public int CDCBBIHPMMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public T HBDLGDLEPJD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly Dictionary<object, PPPDJIKPDIF> OBJPMEDBNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly EqualityComparer<T> CPGDPAJJFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private T GPLMGMGJPBG;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public virtual T BIAGEMBCPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xE416F0", Offset = "0xE404F0", VA = "0x180E416F0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x6DCFC80", Offset = "0x6DCEA80", VA = "0x186DCFC80", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public bool KFGGANBJPHF
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x6DCFD50", Offset = "0x6DCEB50", VA = "0x186DCFD50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public object PIMHBIHOAGG
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xA59850", Offset = "0xA58650", VA = "0x180A59850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xA59890", Offset = "0xA58690", VA = "0x180A59890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x6DCF580", Offset = "0x6DCE380", VA = "0x186DCF580")]
	public bool GDOMOJLGIKD(T BNECONOIKOE, object OCGDLEBGIMO, int HNGPPDLEICO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x6DCF190", Offset = "0x6DCDF90", VA = "0x186DCF190")]
	public bool FGGHDPDBNDA(object OCGDLEBGIMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x6DCEC90", Offset = "0x6DCDA90", VA = "0x186DCEC90")]
	public bool BNILIKGEJAF(object OCGDLEBGIMO, [Out] T BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x6DCFD20", Offset = "0x6DCEB20", VA = "0x186DCFD20")]
	public void MKDKKBLDFOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x6DCC250", Offset = "0x6DCB050", VA = "0x186DCC250")]
	private bool ADOFFDCCLFK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x6DCFDA0", Offset = "0x6DCEBA0", VA = "0x186DCFDA0")]
	public DDCPOGLAFMM()
	{
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
