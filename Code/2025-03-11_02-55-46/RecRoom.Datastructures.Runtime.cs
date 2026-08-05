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
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x75B11E0", Offset = "0x75B05E0", VA = "0x1875B11E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x990590", Offset = "0x98F990", VA = "0x180990590")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9905D0", Offset = "0x98F9D0", VA = "0x1809905D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class INKECKOEOIL : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1E71BF0", Offset = "0x1E70FF0", VA = "0x181E71BF0")]
	public INKECKOEOIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, GFPIKGALGLF, MGBHMKALNKB, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x968060", Offset = "0x967460", VA = "0x180968060", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9682E0", Offset = "0x9676E0", VA = "0x1809682E0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x968070", Offset = "0x967470", VA = "0x180968070", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB838A0", Offset = "0xB82CA0", VA = "0x180B838A0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash JPJGMEMJNGO);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xAA00D0", Offset = "0xA9F4D0", VA = "0x180AA00D0")]
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
	[ReadOnlyField]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[ReadOnlyField]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x75B24B0", Offset = "0x75B18B0", VA = "0x1875B24B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x75B2470", Offset = "0x75B1870", VA = "0x1875B2470")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x75B24F0", Offset = "0x75B18F0", VA = "0x1875B24F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x75B26A0", Offset = "0x75B1AA0", VA = "0x1875B26A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x75B2610", Offset = "0x75B1A10", VA = "0x1875B2610")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xDED8E0", Offset = "0xDECCE0", VA = "0x180DED8E0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xC30870", Offset = "0xC2FC70", VA = "0x180C30870")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x75B2430", Offset = "0x75B1830", VA = "0x1875B2430")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x75B2580", Offset = "0x75B1980", VA = "0x1875B2580")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x75B1ED0", Offset = "0x75B12D0", VA = "0x1875B1ED0")]
	public void CopyBounds(SavedExtents MNALNBMKJLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x75B2380", Offset = "0x75B1780", VA = "0x1875B2380")]
	public void SetLocalSpaceBounds(Bounds LCBGIAHFOHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1259420", Offset = "0x1258820", VA = "0x181259420")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x75B2370", Offset = "0x75B1770", VA = "0x1875B2370")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x75B1FC0", Offset = "0x75B13C0", VA = "0x1875B1FC0")]
	private void HIEMOMOECPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x75B2170", Offset = "0x75B1570", VA = "0x1875B2170")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x75B1890", Offset = "0x75B0C90", VA = "0x1875B1890")]
	public static void CalculateLocalBoundsFor(GameObject IIKFCCENKCC, [Out] Bounds LCBGIAHFOHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x75B1F00", Offset = "0x75B1300", VA = "0x1875B1F00")]
	private static void DAGNMAKLAPD(Bounds DOGHGFGEHNK, Color FBGCPEAGLNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x75B23A0", Offset = "0x75B17A0", VA = "0x1875B23A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9641A0", Offset = "0x9635A0", VA = "0x1809641A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x968380", Offset = "0x967780", VA = "0x180968380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x16CD440", Offset = "0x16CC840", VA = "0x1816CD440")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x52D06A0", Offset = "0x52CFAA0", VA = "0x1852D06A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "4")]
	public virtual void NPOBDHDKLPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
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
	[INKECKOEOIL]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x52D0210", Offset = "0x52CF610", VA = "0x1852D0210", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x52CEDE0", Offset = "0x52CE1E0", VA = "0x1852CEDE0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x52D05C0", Offset = "0x52CF9C0", VA = "0x1852D05C0")]
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
	private sealed class LPBEJKBGIMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public LPBEJKBGIMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4C1E800", Offset = "0x4C1DC00", VA = "0x184C1E800")]
		internal int INLKJMDDBJO(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[INKECKOEOIL]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4154A90", Offset = "0x4153E90", VA = "0x184154A90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4154AF0", Offset = "0x4153EF0", VA = "0x184154AF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4154970", Offset = "0x4153D70", VA = "0x184154970", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey MCNLCGLNHHO]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4154A30", Offset = "0x4153E30", VA = "0x184154A30", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4154820", Offset = "0x4153C20", VA = "0x184154820", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x41544C0", Offset = "0x41538C0", VA = "0x1841544C0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4153880", Offset = "0x4152C80", VA = "0x184153880", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4153820", Offset = "0x4152C20", VA = "0x184153820", Slot = "14")]
	protected virtual string IDFJAMFDOJI(TKeyVal BNONCNKMPIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x41536F0", Offset = "0x4152AF0", VA = "0x1841536F0", Slot = "4")]
	public bool ContainsKey(TKey MCNLCGLNHHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x41546A0", Offset = "0x4153AA0", VA = "0x1841546A0", Slot = "5")]
	public bool TryGetValue(TKey MCNLCGLNHHO, [Out] TVal PEBNJNGMMHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4153750", Offset = "0x4152B50", VA = "0x184153750", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4153750", Offset = "0x4152B50", VA = "0x184153750", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4154700", Offset = "0x4153B00", VA = "0x184154700")]
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
	[SerializeField]
	[SerializeReference]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x969470", Offset = "0x968870", VA = "0x180969470")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x968060", Offset = "0x967460", VA = "0x180968060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
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
		[Cpp2IlInjected.Address(RVA = "0x40B57F0", Offset = "0x40B4BF0", VA = "0x1840B57F0")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[INKECKOEOIL]
	[SerializeField]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x52D2090", Offset = "0x52D1490", VA = "0x1852D2090")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x52D18D0", Offset = "0x52D0CD0", VA = "0x1852D18D0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x52D0E80", Offset = "0x52D0280", VA = "0x1852D0E80", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class GNBGONEPKEM<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct PDFAADIKCFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public T KAMPPLLIEDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public float KCGBFPCDPEB;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int INBEBJFMGGH = 16;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const float GDEJBFDIGEP = -1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected readonly PDFAADIKCFF[] PHAPILEGACC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	protected int JAHOMAGDFPB;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float JFGICFNFHKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xB0AF90", Offset = "0xB0A390", VA = "0x180B0AF90")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xB701C0", Offset = "0xB6F5C0", VA = "0x180B701C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public T GGHFKECIEFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x968060", Offset = "0x967460", VA = "0x180968060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x46C3590", Offset = "0x46C2990", VA = "0x1846C3590")]
	protected GNBGONEPKEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x46C35D0", Offset = "0x46C29D0", VA = "0x1846C35D0")]
	protected GNBGONEPKEM(int NBPEDBIONNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x46C3480", Offset = "0x46C2880", VA = "0x1846C3480")]
	public void KAAHFJDOOLK(float LLHIMIEALOC, T PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool OGNDNMAJPHF(float AMOMCNHNNKK, float OACKEHNBMJK, [Out] T PEBNJNGMMHE);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool EPOPLMDFBDJ(float AMOMCNHNNKK, float OACKEHNBMJK, [Out] T PEBNJNGMMHE);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x46C32A0", Offset = "0x46C26A0", VA = "0x1846C32A0")]
	public void JIMFDDOIBMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class FAKGIMHEDNN : GNBGONEPKEM<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x75ADC10", Offset = "0x75AD010", VA = "0x1875ADC10", Slot = "4")]
	public override bool OGNDNMAJPHF(float AMOMCNHNNKK, float OACKEHNBMJK, [Out] Vector3 PEBNJNGMMHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x75ADAD0", Offset = "0x75ACED0", VA = "0x1875ADAD0", Slot = "5")]
	public override bool EPOPLMDFBDJ(float AMOMCNHNNKK, float OACKEHNBMJK, [Out] Vector3 PEBNJNGMMHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x75ADD70", Offset = "0x75AD170", VA = "0x1875ADD70")]
	public FAKGIMHEDNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class JKHOAHFNIEL
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x351D5A0", Offset = "0x351C9A0", VA = "0x18351D5A0")]
	public static HEBLJOLGLMI<T1, T2> GEEFBNOOFMP<T1, T2>(T1 DOAKBLFEFAA, T2 IBAKNKLCLOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x351D640", Offset = "0x351CA40", VA = "0x18351D640")]
	public static LDKMMMEACPP<T1, T2, T3> GEEFBNOOFMP<T1, T2, T3>(T1 DOAKBLFEFAA, T2 IBAKNKLCLOH, T3 PKDIHJKJMCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4E5C2E0", Offset = "0x4E5B6E0", VA = "0x184E5C2E0")]
	internal static int BIHIIBHLLOB(int LDFOLOJGCDB, int IKLDCNNPOAM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x685C950", Offset = "0x685BD50", VA = "0x18685C950")]
	internal static int BIHIIBHLLOB(int LDFOLOJGCDB, int IKLDCNNPOAM, int JHKHICCEIJH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HEBLJOLGLMI<T1, T2> : IComparable<HEBLJOLGLMI<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T1 HAOJILPNOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T2 AHLAAENJODA;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x471E0F0", Offset = "0x471D4F0", VA = "0x18471E0F0")]
	public HEBLJOLGLMI(T1 DOAKBLFEFAA, T2 IBAKNKLCLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x471C390", Offset = "0x471B790", VA = "0x18471C390", Slot = "4")]
	public int CompareTo(HEBLJOLGLMI<T1, T2> MNALNBMKJLK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x471CA00", Offset = "0x471BE00", VA = "0x18471CA00", Slot = "0")]
	public override bool Equals(object MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x471D3D0", Offset = "0x471C7D0", VA = "0x18471D3D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x471D950", Offset = "0x471CD50", VA = "0x18471D950", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class LDKMMMEACPP<T1, T2, T3> : IComparable<LDKMMMEACPP<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T1 HAOJILPNOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T2 AHLAAENJODA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T3 MBBHEIEBPDD;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4BE4330", Offset = "0x4BE3730", VA = "0x184BE4330")]
	public LDKMMMEACPP(T1 DOAKBLFEFAA, T2 IBAKNKLCLOH, T3 PKDIHJKJMCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4BE39C0", Offset = "0x4BE2DC0", VA = "0x184BE39C0", Slot = "4")]
	public int CompareTo(LDKMMMEACPP<T1, T2, T3> MNALNBMKJLK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4BE3D90", Offset = "0x4BE3190", VA = "0x184BE3D90", Slot = "0")]
	public override bool Equals(object MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4BE3F40", Offset = "0x4BE3340", VA = "0x184BE3F40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4BE4070", Offset = "0x4BE3470", VA = "0x184BE4070", Slot = "3")]
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
	public AnimationCurve HKEJFMGBCKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T HMNFDLJJBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xE11DF0", Offset = "0xE111F0", VA = "0x180E11DF0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T KBKJIFBOJFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xAFAF40", Offset = "0xAFA340", VA = "0x180AFAF40")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T KAMPPLLIEDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x29662E0", Offset = "0x29656E0", VA = "0x1829662E0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2966490", Offset = "0x2965890", VA = "0x182966490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float ODLGOLDGHON
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xAEF480", Offset = "0xAEE880", VA = "0x180AEF480")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5549550", Offset = "0x5548950", VA = "0x185549550")]
	public T KPFDFDMJGNL(float MPAMMAGABHA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x55490E0", Offset = "0x55484E0", VA = "0x1855490E0")]
	public T JABAMKDNDGI(float MPAMMAGABHA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T LKLNOIOJMDI(T HGHHJPDLMPJ, T OLNKLOFDFBI, float MPAMMAGABHA);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x75ADDB0", Offset = "0x75AD1B0", VA = "0x1875ADDB0", Slot = "4")]
	protected override float LKLNOIOJMDI(float HGHHJPDLMPJ, float OLNKLOFDFBI, float MPAMMAGABHA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x75ADDF0", Offset = "0x75AD1F0", VA = "0x1875ADDF0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x155A290", Offset = "0x1559690", VA = "0x18155A290", Slot = "4")]
	protected override Vector3 LKLNOIOJMDI(Vector3 HGHHJPDLMPJ, Vector3 OLNKLOFDFBI, float MPAMMAGABHA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x75B3440", Offset = "0x75B2840", VA = "0x1875B3440")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x75AD460", Offset = "0x75AC860", VA = "0x1875AD460", Slot = "4")]
	protected override Color LKLNOIOJMDI(Color HGHHJPDLMPJ, Color OLNKLOFDFBI, float MPAMMAGABHA)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x75AD520", Offset = "0x75AC920", VA = "0x1875AD520")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class CDKJGLLJIPB : MINFDDDCNGE<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x75AD410", Offset = "0x75AC810", VA = "0x1875AD410")]
	public CDKJGLLJIPB(int JJLMBBEIKLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x75AD3A0", Offset = "0x75AC7A0", VA = "0x1875AD3A0", Slot = "6")]
	protected override uint IDOMKHJAECC(uint JPJGMEMJNGO, string PEBNJNGMMHE)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class HGOJDDFEPMP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly IDisposable AJPLFLPAHGP;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public HGOJDDFEPMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct NEGGOGBBOCI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> HEHMJIJKIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int GEAACCNKNFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int DNBKOIPEAOM;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4654C60", Offset = "0x4654060", VA = "0x184654C60")]
	private NEGGOGBBOCI(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> NLKOCFCNPAA, int HIJADGEGAOM, int EGEKGCPMEJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4E79460", Offset = "0x4E78860", VA = "0x184E79460")]
	public static NEGGOGBBOCI<T> KMDIICJFNJF()
	{
		return default(NEGGOGBBOCI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4E785A0", Offset = "0x4E779A0", VA = "0x184E785A0")]
	public (int, int, Task<T>) BLDBONLJJBN(int OOHLOECMMAJ, [Optional] CancellationToken MLAPMBKLAOF, double JJPFHPNOEHC = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4E79250", Offset = "0x4E78650", VA = "0x184E79250")]
	public void ICJMCGBBNCK(int OOHLOECMMAJ, int EGEKGCPMEJG, [In] T HOCIBOCHCFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class EKPNJNFNGEJ
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x75ADA80", Offset = "0x75ACE80", VA = "0x1875ADA80")]
	public static NEGGOGBBOCI<AOFFOIKPJDJ> KMDIICJFNJF()
	{
		return default(NEGGOGBBOCI<AOFFOIKPJDJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x75ADA00", Offset = "0x75ACE00", VA = "0x1875ADA00")]
	public static void ICJMCGBBNCK([In] this NEGGOGBBOCI<AOFFOIKPJDJ> IIICNLIAPBJ, int OOHLOECMMAJ, int EGEKGCPMEJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class NHNBBIGCHBE<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly Dictionary<TKey, TVal> NONFKPONHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TVal, TKey> OKDJHEGABGG;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int ECPNGLCMABA
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3D73AE0", Offset = "0x3D72EE0", VA = "0x183D73AE0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool FBPFCDPCCGG
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> GOPICAIOKFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x4825CD0", Offset = "0x48250D0", VA = "0x184825CD0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> DELDPIMGFKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x482E600", Offset = "0x482DA00", VA = "0x18482E600", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal BNGIPFMNGPK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x4E8BFE0", Offset = "0x4E8B3E0", VA = "0x184E8BFE0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x4E8C080", Offset = "0x4E8B480", VA = "0x184E8C080", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey BNGIPFMNGPK
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x4E8B7C0", Offset = "0x4E8ABC0", VA = "0x184E8B7C0")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4E8B570", Offset = "0x4E8A970", VA = "0x184E8B570", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4E8BDC0", Offset = "0x4E8B1C0", VA = "0x184E8BDC0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4E8B250", Offset = "0x4E8A650", VA = "0x184E8B250", Slot = "9")]
	public void Add(TKey MCNLCGLNHHO, TVal PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4E8B2F0", Offset = "0x4E8A6F0", VA = "0x184E8B2F0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> BBKCHLGPMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4E8B610", Offset = "0x4E8AA10", VA = "0x184E8B610", Slot = "8")]
	public bool ContainsKey(TKey MCNLCGLNHHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4E8B6A0", Offset = "0x4E8AAA0", VA = "0x184E8B6A0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> BBKCHLGPMMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4E8BD00", Offset = "0x4E8B100", VA = "0x184E8BD00", Slot = "10")]
	public bool Remove(TKey MCNLCGLNHHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4E8BD40", Offset = "0x4E8B140", VA = "0x184E8BD40", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> BBKCHLGPMMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4E8BE60", Offset = "0x4E8B260", VA = "0x184E8BE60", Slot = "11")]
	public bool TryGetValue(TKey MCNLCGLNHHO, [Out] TVal PEBNJNGMMHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4E8B820", Offset = "0x4E8AC20", VA = "0x184E8B820", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4E8B6E0", Offset = "0x4E8AAE0", VA = "0x184E8B6E0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] PHAPILEGACC, int BCEHLPADKCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4E8BC40", Offset = "0x4E8B040", VA = "0x184E8BC40")]
	public bool POFMAEKIJGP(TVal MCNLCGLNHHO, [Out] TKey PEBNJNGMMHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4E8BA80", Offset = "0x4E8AE80", VA = "0x184E8BA80")]
	private void KCINBNMDDHE(TKey MCNLCGLNHHO, TVal GHFLHNCPIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4E8B8C0", Offset = "0x4E8ACC0", VA = "0x184E8B8C0")]
	private void IDEAFDAEOOP(TKey MCNLCGLNHHO, TVal GHFLHNCPIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4E8B340", Offset = "0x4E8A740", VA = "0x184E8B340")]
	private bool CPOOIKDIFDM(TKey MCNLCGLNHHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4E8BEC0", Offset = "0x4E8B2C0", VA = "0x184E8BEC0")]
	public NHNBBIGCHBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class PCCHDFHNMOC<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private PCCHDFHNMOC<T> buffer;

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
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x10DE300", Offset = "0x10DD700", VA = "0x1810DE300", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x41B0050", Offset = "0x41AF450", VA = "0x1841B0050", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x41B1AA0", Offset = "0x41B0EA0", VA = "0x1841B1AA0")]
		public Enumerator(PCCHDFHNMOC<T> LMNIHILKKEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x41AEC30", Offset = "0x41AE030", VA = "0x1841AEC30", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x41AFC50", Offset = "0x41AF050", VA = "0x1841AFC50", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x41ADD20", Offset = "0x41AD120", VA = "0x1841ADD20")]
		private void GHGKPDDFEPE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private T[] MPMKDLIMCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int PFCFNJKDJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int OLOBLBBCLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int IFKCKGNMHDI;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int ECPNGLCMABA
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5083BC0", Offset = "0x5082FC0", VA = "0x185083BC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T BNGIPFMNGPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5083D20", Offset = "0x5083120", VA = "0x185083D20")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5084F50", Offset = "0x5084350", VA = "0x185084F50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5085480", Offset = "0x5084880", VA = "0x185085480")]
	public PCCHDFHNMOC(int JJLMBBEIKLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5084400", Offset = "0x5083800", VA = "0x185084400")]
	public void KAAHFJDOOLK(T MPAMMAGABHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5083F10", Offset = "0x5083310", VA = "0x185083F10")]
	public void JIMFDDOIBMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5084520", Offset = "0x5083920", VA = "0x185084520")]
	public void KAJOGNPOFEC(int LOHPPDCIAAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5083320", Offset = "0x5082720", VA = "0x185083320")]
	public void BENBCGCNJFB(T[] PHAPILEGACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5085090", Offset = "0x5084490", VA = "0x185085090")]
	public Enumerator NFFMPMPKJEP()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5085220", Offset = "0x5084620", VA = "0x185085220", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5085220", Offset = "0x5084620", VA = "0x185085220", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5084980", Offset = "0x5083D80", VA = "0x185084980")]
	private int LKIPEAGDENG(int FFCBHHABFJN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x50832F0", Offset = "0x50826F0", VA = "0x1850832F0")]
	private int BACHEACPHNK(int FFCBHHABFJN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class IONONCKAOIB<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate Task<TResult> KHDCNPHGMEB(TRequest NKKKCKHLGCJ, CancellationToken MLAPMBKLAOF);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum CMAFIHONOKK
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class IDPNIOIDFEC
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const float PDOBNNEEKIL = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TimeSpan FMKBNKHPFCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int PLMHPBHDCAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CMAFIHONOKK JBNMABKJFBE;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly IDPNIOIDFEC LPOHMOGIBPI;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float AILJDDFMNEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x48066E0", Offset = "0x4805AE0", VA = "0x1848066E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public TimeSpan LPBIOCFNJJP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x48067C0", Offset = "0x4805BC0", VA = "0x1848067C0")]
		public IDPNIOIDFEC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private readonly struct OGCMGPCGEIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public readonly TRequest NKKKCKHLGCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly CancellationToken MLAPMBKLAOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly TaskCompletionSource<TResult> MCKEDAHELGN;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x4FA2330", Offset = "0x4FA1730", VA = "0x184FA2330")]
		public OGCMGPCGEIC(TRequest NKKKCKHLGCJ, TaskCompletionSource<TResult> MCKEDAHELGN, CancellationToken MLAPMBKLAOF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct PLIMECODHDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public IONONCKAOIB<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x50D0B40", Offset = "0x50CFF40", VA = "0x1850D0B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x50D0FA0", Offset = "0x50D03A0", VA = "0x1850D0FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct PMKLICOEOIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IONONCKAOIB<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private OGCMGPCGEIC <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x50D5970", Offset = "0x50D4D70", VA = "0x1850D5970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x50D65A0", Offset = "0x50D59A0", VA = "0x1850D65A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CancellationTokenSource NJJDPIIGJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly List<OGCMGPCGEIC> JOHPGPGGEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IDPNIOIDFEC JPHJHPFGPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly KHDCNPHGMEB FLDLPCGNPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Task KMBNPLKGBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int BEIKODAHKHN;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x48441F0", Offset = "0x48435F0", VA = "0x1848441F0")]
	public IONONCKAOIB(KHDCNPHGMEB FLDLPCGNPJK, [Optional] IDPNIOIDFEC JPHJHPFGPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4843BC0", Offset = "0x4842FC0", VA = "0x184843BC0")]
	public Task<TResult> LGICPDHLILL(TRequest NKKKCKHLGCJ, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x48437E0", Offset = "0x4842BE0", VA = "0x1848437E0")]
	private void JKJMOLCMEKD(OGCMGPCGEIC GMKHGDCAKJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4843640", Offset = "0x4842A40", VA = "0x184843640")]
	[AsyncStateMachine(typeof(IONONCKAOIB<, >.PLIMECODHDG))]
	private Task JDMBLBOHIJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4842B90", Offset = "0x4841F90", VA = "0x184842B90")]
	private OGCMGPCGEIC BCICIOEMOJA()
	{
		return default(OGCMGPCGEIC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x48426E0", Offset = "0x4841AE0", VA = "0x1848426E0")]
	[AsyncStateMachine(typeof(IONONCKAOIB<, >.PMKLICOEOIB))]
	private Task ANHCMMMCNLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x48433A0", Offset = "0x48427A0", VA = "0x1848433A0")]
	private void EKNFPPLPGLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4843160", Offset = "0x4842560", VA = "0x184843160", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class GKFCIHCNNCP<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly List<T> DBJKHFJBKPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private HashSet<T> ALJEHOCLMNH;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int ECPNGLCMABA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3D73AE0", Offset = "0x3D72EE0", VA = "0x183D73AE0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool FBPFCDPCCGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T BNGIPFMNGPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x36D0480", Offset = "0x36CF880", VA = "0x1836D0480", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4677CC0", Offset = "0x46770C0", VA = "0x184677CC0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x45BE500", Offset = "0x45BD900", VA = "0x1845BE500", Slot = "11")]
	public void Add(T BBKCHLGPMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4677290", Offset = "0x4676690", VA = "0x184677290")]
	public bool HFNMILCCPIO(T BBKCHLGPMMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4677A20", Offset = "0x4676E20", VA = "0x184677A20", Slot = "15")]
	public bool Remove(T BBKCHLGPMMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4677200", Offset = "0x4676600", VA = "0x184677200", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x45E9E30", Offset = "0x45E9230", VA = "0x1845E9E30", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x46770B0", Offset = "0x46764B0", VA = "0x1846770B0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4677150", Offset = "0x4676550", VA = "0x184677150", Slot = "13")]
	public bool Contains(T BBKCHLGPMMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x46771A0", Offset = "0x46765A0", VA = "0x1846771A0", Slot = "14")]
	public void CopyTo(T[] PHAPILEGACC, int BCEHLPADKCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4677490", Offset = "0x4676890", VA = "0x184677490", Slot = "6")]
	public int IndexOf(T BBKCHLGPMMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4677640", Offset = "0x4676A40", VA = "0x184677640", Slot = "7")]
	public void Insert(int FFCBHHABFJN, T BBKCHLGPMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4677780", Offset = "0x4676B80", VA = "0x184677780", Slot = "8")]
	public void RemoveAt(int FFCBHHABFJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4677BA0", Offset = "0x4676FA0", VA = "0x184677BA0")]
	public GKFCIHCNNCP()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
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
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x27CC990", Offset = "0x27CBD90", VA = "0x1827CC990")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2337CD0", Offset = "0x23370D0", VA = "0x182337CD0")]
		public SerializedGuid([In] Guid BCIHOIBCNMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x75B2730", Offset = "0x75B1B30", VA = "0x1875B2730")]
		public static SerializedGuid AGDMFDAJBNG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x75B2920", Offset = "0x75B1D20", VA = "0x1875B2920")]
		public static SerializedGuid MBLOGMHAFLH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x75B27E0", Offset = "0x75B1BE0", VA = "0x1875B27E0")]
		public bool EAANCJCJLOJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x75B2A10", Offset = "0x75B1E10", VA = "0x1875B2A10", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x75B2990", Offset = "0x75B1D90", VA = "0x1875B2990", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x75B2840", Offset = "0x75B1C40", VA = "0x1875B2840", Slot = "7")]
		public bool Equals(SerializedGuid MNALNBMKJLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x75B2880", Offset = "0x75B1C80", VA = "0x1875B2880", Slot = "0")]
		public override bool Equals(object NBAMGPFDMIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x75B2910", Offset = "0x75B1D10", VA = "0x1875B2910", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x75B27B0", Offset = "0x75B1BB0", VA = "0x1875B27B0", Slot = "6")]
		public int CompareTo(SerializedGuid MNALNBMKJLK)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class OPNDHHNECPA : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Type KPJDMAHNKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly string CGIHBMDCFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly bool BPGLEAEJACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly bool CMDNEGKFHME;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x75B12F0", Offset = "0x75B06F0", VA = "0x1875B12F0")]
	public OPNDHHNECPA(Type OFEGPDPMEIM, string DEJIJPHJPGB, bool EBNJHBOHGBC = false, bool GIBPJFMIGLK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface ALHEHJJNJDC<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	int AJNDIJIKIND
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<T> DNFDNDEEPNA(float LLHIMIEALOC, [Optional] float? OEGJHKNCJOC);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CGGIIADEDFE(float LLHIMIEALOC, T PEBNJNGMMHE);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JIMFDDOIBMF();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Obsolete("Use ITimeSeriesRollingWindow<T> instead")]
public class JOJCCPODNOK<T> : ALHEHJJNJDC<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private class LDHPDKOGBIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float BPMMCGJICOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public T KAMPPLLIEDO;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public LDHPDKOGBIC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class HCKFNIOGBCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public HCKFNIOGBCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x4713090", Offset = "0x4712490", VA = "0x184713090")]
		internal bool GEJPBLAMGIG(LDHPDKOGBIC sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly float GAHAJNKHHMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly float PKONONHMPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<LDHPDKOGBIC> AAFPNKGCKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private BHCCHKHANLD<LDHPDKOGBIC> LOKGKNDEOHA;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int AJNDIJIKIND
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x4A3BB10", Offset = "0x4A3AF10", VA = "0x184A3BB10", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4A3BB80", Offset = "0x4A3AF80", VA = "0x184A3BB80")]
	public JOJCCPODNOK(float IKGINFFMDIJ, float BNNNBDLIAEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4A3AF90", Offset = "0x4A3A390", VA = "0x184A3AF90", Slot = "6")]
	public bool CGGIIADEDFE(float LLHIMIEALOC, T PEBNJNGMMHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4A3B160", Offset = "0x4A3A560", VA = "0x184A3B160", Slot = "5")]
	public IEnumerable<T> DNFDNDEEPNA(float LLHIMIEALOC, float? OEGJHKNCJOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4A3B840", Offset = "0x4A3AC40", VA = "0x184A3B840", Slot = "7")]
	public void JIMFDDOIBMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4A3B8F0", Offset = "0x4A3ACF0", VA = "0x184A3B8F0")]
	private void LCBBBGCFNMB(float LLHIMIEALOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class OCMFBHALMCJ<T> : ALHEHJJNJDC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct BDBHEHJKJAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly T KAMPPLLIEDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly float BPMMCGJICOL;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x4BC3940", Offset = "0x4BC2D40", VA = "0x184BC3940")]
		public BDBHEHJKJAA(T PEBNJNGMMHE, float LLHIMIEALOC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class KDDCNDKLBAG : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
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
		public OCMFBHALMCJ<T> <>4__this;

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
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xD752B0", Offset = "0xD746B0", VA = "0x180D752B0")]
		[DebuggerHidden]
		public KDDCNDKLBAG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4AF0E10", Offset = "0x4AF0210", VA = "0x184AF0E10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x4AF1340", Offset = "0x4AF0740", VA = "0x184AF1340", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x4AF1180", Offset = "0x4AF0580", VA = "0x184AF1180", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x46107A0", Offset = "0x460FBA0", VA = "0x1846107A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly float IKGINFFMDIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly float BNNNBDLIAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly List<BDBHEHJKJAA> AAFPNKGCKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int PFCFNJKDJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int JFLFBLEDCBK;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int AJNDIJIKIND
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x968340", Offset = "0x967740", VA = "0x180968340", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4F9C150", Offset = "0x4F9B550", VA = "0x184F9C150")]
	public OCMFBHALMCJ(float IKGINFFMDIJ, float BNNNBDLIAEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4F9B690", Offset = "0x4F9AA90", VA = "0x184F9B690", Slot = "6")]
	public bool CGGIIADEDFE(float LLHIMIEALOC, T PEBNJNGMMHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4F9B640", Offset = "0x4F9AA40", VA = "0x184F9B640", Slot = "8")]
	public int BBFCFLBDFMO(float LLHIMIEALOC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4F9BCC0", Offset = "0x4F9B0C0", VA = "0x184F9BCC0", Slot = "5")]
	[IteratorStateMachine(typeof(OCMFBHALMCJ<>.KDDCNDKLBAG))]
	public IEnumerable<T> DNFDNDEEPNA(float LLHIMIEALOC, float? OEGJHKNCJOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4F9BF10", Offset = "0x4F9B310", VA = "0x184F9BF10", Slot = "7")]
	public void JIMFDDOIBMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4F9BF70", Offset = "0x4F9B370", VA = "0x184F9BF70")]
	private void PINOBPEMGNE(float LLHIMIEALOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4F9BE40", Offset = "0x4F9B240", VA = "0x184F9BE40")]
	private BDBHEHJKJAA DPOKBEPDPAB()
	{
		return default(BDBHEHJKJAA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class PGLLJHOKMII<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public readonly struct BGMGLKBLOBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly long GJLNNKKHIHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly long OAPPAGGONCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly int KNLEBLCHBJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly int MGHGLMAHJOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly bool GKFGKIOILDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly string HPOPCOHBACF;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5C858B0", Offset = "0x5C84CB0", VA = "0x185C858B0")]
		public BGMGLKBLOBC(long GJLNNKKHIHA, int KNLEBLCHBJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5C85920", Offset = "0x5C84D20", VA = "0x185C85920")]
		public BGMGLKBLOBC(long GJLNNKKHIHA, long OAPPAGGONCE, int KNLEBLCHBJP, int MGHGLMAHJOB, bool GKFGKIOILDK, string HPOPCOHBACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5C857C0", Offset = "0x5C84BC0", VA = "0x185C857C0")]
		public int LKHDGKKHKJD()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5C85740", Offset = "0x5C84B40", VA = "0x185C85740")]
		public int JNEEJIACNBL(int KCPILGADMPA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5C85760", Offset = "0x5C84B60", VA = "0x185C85760")]
		public double LDJLBLPGBOJ()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5C85810", Offset = "0x5C84C10", VA = "0x185C85810")]
		public BGMGLKBLOBC MLEBNIFLLEC(long OAPPAGGONCE, int MGHGLMAHJOB)
		{
			return default(BGMGLKBLOBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class GLACLJPMODI : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private struct EMNBPIBOJME<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public GLACLJPMODI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Func<GLACLJPMODI, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private GLACLJPMODI <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x4133DD0", Offset = "0x41331D0", VA = "0x184133DD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x4134300", Offset = "0x4133700", VA = "0x184134300", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly TKey AMKBEFCENEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly PGLLJHOKMII<TKey> LMBGFJBPMAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly HLBHMADGLFA GCIBFPDCNDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private List<GLACLJPMODI> AEPHKDLGHIM;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string MGKEBMODLJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x4678B70", Offset = "0x4677F70", VA = "0x184678B70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public IEnumerable<GLACLJPMODI> BDIJHLKFMND
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x46786E0", Offset = "0x4677AE0", VA = "0x1846786E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public BGMGLKBLOBC LHDPAGFAEDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x4678B50", Offset = "0x4677F50", VA = "0x184678B50")]
			[CompilerGenerated]
			get
			{
				return default(BGMGLKBLOBC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x4678B20", Offset = "0x4677F20", VA = "0x184678B20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4678BC0", Offset = "0x4677FC0", VA = "0x184678BC0")]
		internal GLACLJPMODI(PGLLJHOKMII<TKey> LMBGFJBPMAJ, TKey MCNLCGLNHHO, HLBHMADGLFA GCIBFPDCNDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4678720", Offset = "0x4677B20", VA = "0x184678720")]
		public GLACLJPMODI CABHFIHJANG(TKey MCNLCGLNHHO, [Optional] HLBHMADGLFA? ICKDJBOHIAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x36D7B40", Offset = "0x36D6F40", VA = "0x1836D7B40")]
		[AsyncStateMachine(typeof(EMNBPIBOJME<>))]
		public Task<T> ABPDDIMKPNC<T>(TKey MCNLCGLNHHO, Func<GLACLJPMODI, Task<T>> JPHIIBFAEAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x46788D0", Offset = "0x4677CD0", VA = "0x1846788D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class JFNKHODOFGM : IEnumerable<(TKey, List<TKey>, BGMGLKBLOBC)>, IEnumerable, IEnumerator<(TKey, List<TKey>, BGMGLKBLOBC)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private (TKey key, List<TKey> path, BGMGLKBLOBC timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public PGLLJHOKMII<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private IEnumerator<(TKey key, List<TKey> path, BGMGLKBLOBC timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private (TKey, List<TKey>, BGMGLKBLOBC) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x27CCC50", Offset = "0x27CC050", VA = "0x1827CCC50", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, BGMGLKBLOBC));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x4A10730", Offset = "0x4A0FB30", VA = "0x184A10730", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x27CCD40", Offset = "0x27CC140", VA = "0x1827CCD40")]
		[DebuggerHidden]
		public JFNKHODOFGM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x459F180", Offset = "0x459E580", VA = "0x18459F180", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4A10270", Offset = "0x4A0F670", VA = "0x184A10270", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4A10220", Offset = "0x4A0F620", VA = "0x184A10220")]
		private void MHCHPBFCGPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x4A106E0", Offset = "0x4A0FAE0", VA = "0x184A106E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x4A10610", Offset = "0x4A0FA10", VA = "0x184A10610", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, BGMGLKBLOBC)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x45D68B0", Offset = "0x45D5CB0", VA = "0x1845D68B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class PNNBGFACKDG : IEnumerable<(TKey, List<TKey>, BGMGLKBLOBC)>, IEnumerable, IEnumerator<(TKey, List<TKey>, BGMGLKBLOBC)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private (TKey key, List<TKey> path, BGMGLKBLOBC timerEntry) <>2__current;

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
		private GLACLJPMODI timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public GLACLJPMODI <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public PGLLJHOKMII<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IEnumerator<GLACLJPMODI> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private IEnumerator<(TKey key, List<TKey> path, BGMGLKBLOBC timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private (TKey, List<TKey>, BGMGLKBLOBC) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x27CCC50", Offset = "0x27CC050", VA = "0x1827CCC50", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, BGMGLKBLOBC));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x50D7720", Offset = "0x50D6B20", VA = "0x1850D7720", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x27CCD40", Offset = "0x27CC140", VA = "0x1827CCD40")]
		[DebuggerHidden]
		public PNNBGFACKDG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x50D7780", Offset = "0x50D6B80", VA = "0x1850D7780", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x50D6DC0", Offset = "0x50D61C0", VA = "0x1850D6DC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x50D6D60", Offset = "0x50D6160", VA = "0x1850D6D60")]
		private void MHCHPBFCGPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x50D6D00", Offset = "0x50D6100", VA = "0x1850D6D00")]
		private void GADEEDGNJBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x50D76D0", Offset = "0x50D6AD0", VA = "0x1850D76D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x50D7590", Offset = "0x50D6990", VA = "0x1850D7590", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, BGMGLKBLOBC)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x50D7690", Offset = "0x50D6A90", VA = "0x1850D7690", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Action<TKey, BGMGLKBLOBC, HLBHMADGLFA> JKIFMFNFFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Action<TKey, BGMGLKBLOBC, HLBHMADGLFA> GNGIFGGHKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly Action<PGLLJHOKMII<TKey>, HLBHMADGLFA> NAGIJOBPDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly GLACLJPMODI FMEICLBEEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private bool JBOKBJOADDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int BLEBJMKHKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Stopwatch LGHJDBIOHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly int EHEFGHGIGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private string EPJBEHKPHJH;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public GLACLJPMODI EHCHEDODEAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x969440", Offset = "0x968840", VA = "0x180969440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	[NotNull]
	public string MGKEBMODLJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x9642B0", Offset = "0x9636B0", VA = "0x1809642B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5096CF0", Offset = "0x50960F0", VA = "0x185096CF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5096D50", Offset = "0x5096150", VA = "0x185096D50")]
	public PGLLJHOKMII(TKey DLDCJEIBDOJ, HLBHMADGLFA GCIBFPDCNDK, [Optional] int? KNLEBLCHBJP, [Optional][CanBeNull] Stopwatch LGHJDBIOHDI, [Optional] Action<TKey, BGMGLKBLOBC, HLBHMADGLFA> JKIFMFNFFIC, [Optional] Action<TKey, BGMGLKBLOBC, HLBHMADGLFA> GNGIFGGHKKF, [Optional] Action<PGLLJHOKMII<TKey>, HLBHMADGLFA> NAGIJOBPDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5096BA0", Offset = "0x5095FA0", VA = "0x185096BA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5096A20", Offset = "0x5095E20", VA = "0x185096A20")]
	[IteratorStateMachine(typeof(PGLLJHOKMII<>.JFNKHODOFGM))]
	public IEnumerable<(TKey, List<TKey>, BGMGLKBLOBC)> BHGDFLOAKHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5096AC0", Offset = "0x5095EC0", VA = "0x185096AC0")]
	[IteratorStateMachine(typeof(PGLLJHOKMII<>.PNNBGFACKDG))]
	private IEnumerable<(TKey, List<TKey>, BGMGLKBLOBC)> BHGDFLOAKHK(List<TKey> CBAOKODFJCF, GLACLJPMODI PNJLGKMNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5096C70", Offset = "0x5096070", VA = "0x185096C70")]
	private (long, int) HJIGPOKPDFA()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public abstract class EPAJBGBEFEL<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut NDIHEFEIAMJ(PGLLJHOKMII<TKey> LMBGFJBPMAJ);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	protected EPAJBGBEFEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class DBLLJMOLONM<TKey> : EPAJBGBEFEL<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public delegate string CGJNCFJIPJN(TKey MCNLCGLNHHO);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x63E7A60", Offset = "0x63E6E60", VA = "0x1863E7A60")]
	private static string GHPEFDPPOCB(TKey MCNLCGLNHHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x63E7AA0", Offset = "0x63E6EA0", VA = "0x1863E7AA0", Slot = "4")]
	public override string NDIHEFEIAMJ(PGLLJHOKMII<TKey> LMBGFJBPMAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x63E7B80", Offset = "0x63E6F80", VA = "0x1863E7B80")]
	public string NDIHEFEIAMJ(PGLLJHOKMII<TKey> LMBGFJBPMAJ, [NotNull] CGJNCFJIPJN JFJJIBHPMNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string HOGMLGGFGDA(PGLLJHOKMII<TKey> LMBGFJBPMAJ, [NotNull] CGJNCFJIPJN JFJJIBHPMNG);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x4628820", Offset = "0x4627C20", VA = "0x184628820")]
	protected DBLLJMOLONM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class HGHCNDJPDEH<TKey> : EPAJBGBEFEL<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public delegate string HPMMJIMGOGN(TKey MCNLCGLNHHO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly string PKLFNKNJFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly double KDAKHAJICLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly bool OCBAEJAELDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly int DFCBCPNIBBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly ISet<string> MBIJKLNGFBL;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x4748C90", Offset = "0x4748090", VA = "0x184748C90")]
	private static string GHPEFDPPOCB(TKey MCNLCGLNHHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x4749620", Offset = "0x4748A20", VA = "0x184749620")]
	public HGHCNDJPDEH(string PKLFNKNJFMJ = "F2", double KDAKHAJICLG = double.MaxValue, bool OCBAEJAELDL = false, int DFCBCPNIBBJ = int.MaxValue, [Optional] ISet<string> MBIJKLNGFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x4748DA0", Offset = "0x47481A0", VA = "0x184748DA0", Slot = "4")]
	public override Dictionary<string, string> NDIHEFEIAMJ(PGLLJHOKMII<TKey> LMBGFJBPMAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x4748CD0", Offset = "0x47480D0", VA = "0x184748CD0")]
	private bool JFCGONGGADP(string CPLNNDGBPDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4748E80", Offset = "0x4748280", VA = "0x184748E80")]
	public Dictionary<string, string> NDIHEFEIAMJ(PGLLJHOKMII<TKey> LMBGFJBPMAJ, HPMMJIMGOGN JFJJIBHPMNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x4748A20", Offset = "0x4747E20", VA = "0x184748A20")]
	private string EOJAPILMGOB(StringBuilder HDMFFPPHODE, List<TKey> GHNGHBFOEJA, HPMMJIMGOGN JFJJIBHPMNG, bool NGHOIMHPAOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x47494C0", Offset = "0x47488C0", VA = "0x1847494C0")]
	private static void OOPPCEKFEOP(StringBuilder BAGEIEBOLFK, string KEMNMPFMJGB, bool IDPDDDCCPML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class GIJECPPNFAH<TKey> : DBLLJMOLONM<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct ICNFLIDCIDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public CGJNCFJIPJN keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static GIJECPPNFAH<TKey> AJPLFLPAHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly string[] PLMEGAFFNDI;

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x466E110", Offset = "0x466D510", VA = "0x18466E110")]
	private GIJECPPNFAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x466D0C0", Offset = "0x466C4C0", VA = "0x18466D0C0", Slot = "5")]
	protected override string HOGMLGGFGDA(PGLLJHOKMII<TKey> LMBGFJBPMAJ, CGJNCFJIPJN JFJJIBHPMNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x466DED0", Offset = "0x466D2D0", VA = "0x18466DED0")]
	[CompilerGenerated]
	internal static string IIEBIHMPNNL(string BAFBPNGJMIJ, TKey MCNLCGLNHHO, ICNFLIDCIDO P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class CDABGJDCKOC : PGLLJHOKMII<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class OMCNPNLNFLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Action<CDABGJDCKOC, HLBHMADGLFA> callback;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public OMCNPNLNFLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x75B1260", Offset = "0x75B0660", VA = "0x1875B1260")]
		internal void KABGAFDDAAN(PGLLJHOKMII<string> timer, HLBHMADGLFA log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x75AD250", Offset = "0x75AC650", VA = "0x1875AD250")]
	public CDABGJDCKOC(HLBHMADGLFA GCIBFPDCNDK, [Optional] string MLFDNNLLEIJ, [Optional] int? KNLEBLCHBJP, [Optional] Stopwatch LGHJDBIOHDI, [Optional] Action<string, BGMGLKBLOBC, HLBHMADGLFA> JKIFMFNFFIC, [Optional] Action<string, BGMGLKBLOBC, HLBHMADGLFA> GNGIFGGHKKF, [Optional] Action<CDABGJDCKOC, HLBHMADGLFA> NAGIJOBPDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x75AD190", Offset = "0x75AC590", VA = "0x1875AD190")]
	private static Action<PGLLJHOKMII<string>, HLBHMADGLFA> LCOJMLELEKM(Action<CDABGJDCKOC, HLBHMADGLFA> LOGLEICCEGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public abstract class LLKGLIINKMJ
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private class JKEJCPIFLHO : LLKGLIINKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static LLKGLIINKMJ AJPLFLPAHGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x75B0560", Offset = "0x75AF960", VA = "0x1875B0560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override float FGBCJNNKDAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x105D200", Offset = "0x105C600", VA = "0x18105D200", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x75B0650", Offset = "0x75AFA50", VA = "0x1875B0650")]
		public JKEJCPIFLHO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static LLKGLIINKMJ PGKLBDAIBHO;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static LLKGLIINKMJ LPOHMOGIBPI
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x75B0F90", Offset = "0x75B0390", VA = "0x1875B0F90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public abstract float FGBCJNNKDAO
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	protected LLKGLIINKMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface OOEAEINEKGH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	bool DAOBNBLDNKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface JCAOOGBCPCO<T> : OOEAEINEKGH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	[NotNull]
	Task<T> BMIMNALOEKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[NotNull]
	HHPFDJMLPAL<T> MCFAFOBMDAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class MJCKHDDEONB
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x35BDDB0", Offset = "0x35BD1B0", VA = "0x1835BDDB0")]
	public static JCAOOGBCPCO<TResource> ADHDACPNLDF<TResource, TId>(this NNPLAJINIJO<TId, TResource> IHGBEEAPOFO, TId NNKBGKICBEC, [Optional] Func<TId, CancellationToken, Task<TResource>>? NKJPDHNEGEL) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class JLFBGEKNONN
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private sealed class FPHAJEGOPLF<T> : FJHDJJOMPAH<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<T?> BMIMNALOEKI
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override HHPFDJMLPAL<T?> MCFAFOBMDAP
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x9682E0", Offset = "0x9676E0", VA = "0x1809682E0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x458E9D0", Offset = "0x458DDD0", VA = "0x18458E9D0")]
		public FPHAJEGOPLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "10")]
		protected override void BEBNKEGBJLC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class LAFDBFLIIBO<T> : FJHDJJOMPAH<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly T IAIEICIOMDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly Action<T>? DGONPJOIIEK;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Task<T> BMIMNALOEKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x96A760", Offset = "0x969B60", VA = "0x18096A760", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override HHPFDJMLPAL<T> MCFAFOBMDAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x96E0E0", Offset = "0x96D4E0", VA = "0x18096E0E0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x4BC7760", Offset = "0x4BC6B60", VA = "0x184BC7760")]
		public LAFDBFLIIBO(T MCKNMNFEIAK, Action<T>? FKBCDFMCNEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x4BC7700", Offset = "0x4BC6B00", VA = "0x184BC7700", Slot = "10")]
		protected override void BEBNKEGBJLC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class CGJPJAGFOCM<T> : FJHDJJOMPAH<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override Task<T> BMIMNALOEKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override HHPFDJMLPAL<T> MCFAFOBMDAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x9682E0", Offset = "0x9676E0", VA = "0x1809682E0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x6075D10", Offset = "0x6075110", VA = "0x186075D10")]
		public CGJPJAGFOCM(Exception HOGBKOGNANI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "10")]
		protected override void BEBNKEGBJLC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private sealed class GAKJJBEJKJN<T> : FJHDJJOMPAH<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct MMEJPMMIMIM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public Task<JCAOOGBCPCO<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<JCAOOGBCPCO<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x4E14560", Offset = "0x4E13960", VA = "0x184E14560", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x4E14A60", Offset = "0x4E13E60", VA = "0x184E14A60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct MIOAJEMHPKE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public Task<JCAOOGBCPCO<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private TaskAwaiter<JCAOOGBCPCO<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x4E056E0", Offset = "0x4E04AE0", VA = "0x184E056E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x4E05910", Offset = "0x4E04D10", VA = "0x184E05910", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly Task<JCAOOGBCPCO<T>> OKDFMALEJIK;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override Task<T> BMIMNALOEKI
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x9682E0", Offset = "0x9676E0", VA = "0x1809682E0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override HHPFDJMLPAL<T> MCFAFOBMDAP
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x969450", Offset = "0x968850", VA = "0x180969450", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x464B5B0", Offset = "0x464A9B0", VA = "0x18464B5B0")]
		public GAKJJBEJKJN(Task<JCAOOGBCPCO<T>> GELALODAJCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x464AFF0", Offset = "0x464A3F0", VA = "0x18464AFF0", Slot = "10")]
		protected override void BEBNKEGBJLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x464B2D0", Offset = "0x464A6D0", VA = "0x18464B2D0")]
		[AsyncStateMachine(typeof(GAKJJBEJKJN<>.MMEJPMMIMIM))]
		[CompilerGenerated]
		internal static Task<T> DGHHCMNCDGI(Task<JCAOOGBCPCO<T>> GELALODAJCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x464B1F0", Offset = "0x464A5F0", VA = "0x18464B1F0")]
		[AsyncStateMachine(typeof(GAKJJBEJKJN<>.MIOAJEMHPKE))]
		[CompilerGenerated]
		internal static Task DBBNGHLODDN(Task<JCAOOGBCPCO<T>> GELALODAJCE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private sealed class MOHPCLHIIAA<TIn, TOut> : FJHDJJOMPAH<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private struct AALLLKGNDLM : IAsyncStateMachine
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

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x4628860", Offset = "0x4627C60", VA = "0x184628860", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x4628EE0", Offset = "0x46282E0", VA = "0x184628EE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly JCAOOGBCPCO<TIn> JODPBCHKAGE;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override Task<TOut> BMIMNALOEKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x9682E0", Offset = "0x9676E0", VA = "0x1809682E0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override HHPFDJMLPAL<TOut> MCFAFOBMDAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x969450", Offset = "0x968850", VA = "0x180969450", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x4E1E1F0", Offset = "0x4E1D5F0", VA = "0x184E1E1F0")]
		public MOHPCLHIIAA(JCAOOGBCPCO<TIn> ADIHGMHEPMJ, Func<TIn, TOut> HKFEOJPGEEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x4E1DE50", Offset = "0x4E1D250", VA = "0x184E1DE50", Slot = "10")]
		protected override void BEBNKEGBJLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x4E1DEF0", Offset = "0x4E1D2F0", VA = "0x184E1DEF0")]
		[AsyncStateMachine(typeof(MOHPCLHIIAA<, >.AALLLKGNDLM))]
		[CompilerGenerated]
		internal static Task<TOut> NGGHJACBONO(Task<TIn> AIDPLJJNAOB, Func<TIn, TOut> HKFEOJPGEEB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x351D7A0", Offset = "0x351CBA0", VA = "0x18351D7A0")]
	public static JCAOOGBCPCO<T> MAEOIBKNBOE<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x351D820", Offset = "0x351CC20", VA = "0x18351D820")]
	public static JCAOOGBCPCO<T> OGJFGNFHJPP<T>(T HOCIBOCHCFJ, [Optional] Action<T>? FKBCDFMCNEJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x34828A0", Offset = "0x3481CA0", VA = "0x1834828A0")]
	public static JCAOOGBCPCO<T> BDJCBMJDAHH<T>(Exception HOGBKOGNANI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x34828A0", Offset = "0x3481CA0", VA = "0x1834828A0")]
	public static JCAOOGBCPCO<T> PMLMJLCLAIO<T>(Task<JCAOOGBCPCO<T>> GELALODAJCE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x31FD100", Offset = "0x31FC500", VA = "0x1831FD100")]
	public static JCAOOGBCPCO<TOut> KCFIKHGOCAF<TOut, TIn>(JCAOOGBCPCO<TIn> ODHBLOGMAPO, Func<TIn, TOut> HKFEOJPGEEB) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class FJHDJJOMPAH<T> : JCAOOGBCPCO<T>, OOEAEINEKGH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly string BCLPBPAAACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly JKGLJHBPGHO KPFMAHLEDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private bool JBOKBJOADDP;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool DAOBNBLDNKM
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xB8D860", Offset = "0xB8CC60", VA = "0x180B8D860", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public abstract Task<T> BMIMNALOEKI
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public abstract HHPFDJMLPAL<T> MCFAFOBMDAP
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x45096E0", Offset = "0x4508AE0", VA = "0x1845096E0")]
	public FJHDJJOMPAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x45093D0", Offset = "0x45087D0", VA = "0x1845093D0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void BEBNKEGBJLC();
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class LMPEBKOJGNB<TTask, T> : FJHDJJOMPAH<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class DMLIIPPNDCF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
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
			public DMLIIPPNDCF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x3D625F0", Offset = "0x3D619F0", VA = "0x183D625F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x3D628B0", Offset = "0x3D61CB0", VA = "0x183D628B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public LMPEBKOJGNB<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public DMLIIPPNDCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x640CD30", Offset = "0x640C130", VA = "0x18640CD30")]
		[AsyncStateMachine(typeof(LMPEBKOJGNB<, >.DMLIIPPNDCF.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> HEMLMNLGMCE(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Task<T> GELALODAJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	protected readonly CancellationTokenSource GBICCIOOCED;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public override Task<T> BMIMNALOEKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public override HHPFDJMLPAL<T> MCFAFOBMDAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9682E0", Offset = "0x9676E0", VA = "0x1809682E0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x4C1BA10", Offset = "0x4C1AE10", VA = "0x184C1BA10")]
	protected LMPEBKOJGNB(TTask GELALODAJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x4C1B9C0", Offset = "0x4C1ADC0", VA = "0x184C1B9C0", Slot = "10")]
	protected override void BEBNKEGBJLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T KFLHCAMCJBL(TTask FHPAHMEAHON);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void GOMHKNFIAAI();
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class IMIOOKGJNFM<T> : FJHDJJOMPAH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly NIABGHNBMPF<Task<T>> CDJJJHOJHIO;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override Task<T> BMIMNALOEKI
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x4838640", Offset = "0x4837A40", VA = "0x184838640", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override HHPFDJMLPAL<T> MCFAFOBMDAP
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9682E0", Offset = "0x9676E0", VA = "0x1809682E0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x4838690", Offset = "0x4837A90", VA = "0x184838690")]
	public IMIOOKGJNFM(NIABGHNBMPF<Task<T>> EEBOJODOFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x4838620", Offset = "0x4837A20", VA = "0x184838620", Slot = "10")]
	protected override void BEBNKEGBJLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class KDNFNPMEBNO
{
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly HashAlgorithmName MBECPKHPJMP;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly ThreadLocal<IncrementalHash> CFDLPINFIGI;

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x75B0D40", Offset = "0x75B0140", VA = "0x1875B0D40")]
	public static int MFINILPEAKE(this GFPIKGALGLF CNNKMEHBLCF, IncrementalHash JPJGMEMJNGO, byte[] GHNOINHGAAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x75B09D0", Offset = "0x75AFDD0", VA = "0x1875B09D0")]
	public static bool EDPOLNLKNKL([CanBeNull] this GFPIKGALGLF CNNKMEHBLCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x75B0A30", Offset = "0x75AFE30", VA = "0x1875B0A30")]
	public static bool EDPOLNLKNKL([CanBeNull] this GFPIKGALGLF CNNKMEHBLCF, [Out] string JPAKKPAOGDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x75B06A0", Offset = "0x75AFAA0", VA = "0x1875B06A0")]
	public static bool EDPOLNLKNKL([CanBeNull] this GFPIKGALGLF CNNKMEHBLCF, IncrementalHash JPJGMEMJNGO, byte[] GHNOINHGAAL, [Out] string JPAKKPAOGDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x75B0DC0", Offset = "0x75B01C0", VA = "0x1875B0DC0")]
	private static bool MLHOCBKMOHO(byte[] NKFEOODPNKI, Span<byte> GKIJMLKMHCL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class DPLJMGLJKNA
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x75AD560", Offset = "0x75AC960", VA = "0x1875AD560")]
	public static int KPNMFJEOJGL(HashAlgorithmName CCGHDGPJLAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x75AD6B0", Offset = "0x75ACAB0", VA = "0x1875AD6B0")]
	public static int MFINILPEAKE(this MGBHMKALNKB DMDBDIPOLID, byte[] FPJGKDLCKJP, IncrementalHash JPJGMEMJNGO, byte[] IGLEJHLLGMO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface MGBHMKALNKB
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash JPJGMEMJNGO);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface GFPIKGALGLF : MGBHMKALNKB
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	[CanBeNull]
	byte[] GKGPMGIKJKH
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	[CanBeNull]
	byte[] DHENCEOENML
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class JKBPICOLDCP
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static bool PEJOJNKMCNC;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly ArrayPool<byte> EKPFGFPHELP;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly ArrayPool<char> MNKJFPCOJFK;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly Encoding EOHIKMKGGPJ;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly ThreadLocal<Encoder> BIMJONBKGPG;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x351D3E0", Offset = "0x351C7E0", VA = "0x18351D3E0")]
	public static void NJIIELLBPIM<T>(this IncrementalHash ABKAFHNNMFH, [CanBeNull] T LENGNFMPCHL) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x351CD20", Offset = "0x351C120", VA = "0x18351CD20")]
	public static void LHGELFFOLGF<T>(this IncrementalHash ABKAFHNNMFH, [CanBeNull] T DMDBDIPOLID) where T : MGBHMKALNKB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x351C800", Offset = "0x351BC00", VA = "0x18351C800")]
	public static void LDFAPECIFJG<T>(this IncrementalHash ABKAFHNNMFH, [CanBeNull] IList<T> MHAJFAMOCKI) where T : MGBHMKALNKB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x75AF3C0", Offset = "0x75AE7C0", VA = "0x1875AF3C0")]
	private static bool AINJMNDFCPF([CanBeNull] MGBHMKALNKB DMDBDIPOLID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x75AF4B0", Offset = "0x75AE8B0", VA = "0x1875AF4B0")]
	public static void DAMLFPFDPPM(this IncrementalHash JPJGMEMJNGO, string? CIBMCPIODGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x75AFD70", Offset = "0x75AF170", VA = "0x1875AFD70")]
	public static void MMPOLAHEKHI(this IncrementalHash JPJGMEMJNGO, long JDJHCKPDIIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x75AF910", Offset = "0x75AED10", VA = "0x1875AF910")]
	public static void EIEOBPKKHGP(this IncrementalHash JPJGMEMJNGO, int FBAFJDMBDNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x75AFB40", Offset = "0x75AEF40", VA = "0x1875AFB40")]
	public static void JEGPNNJMDEI(this IncrementalHash JPJGMEMJNGO, short NEPHACEFJPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x75B01E0", Offset = "0x75AF5E0", VA = "0x1875B01E0")]
	public static void OBHNEEFCNBB(this IncrementalHash JPJGMEMJNGO, byte JHMNHDGONHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x75AFF40", Offset = "0x75AF340", VA = "0x1875AFF40")]
	public static void NFDHCDNIEDB(this IncrementalHash JPJGMEMJNGO, bool AKHKJCOJLCA, bool FAMDPOJPFGB = false, bool LDDBMHPAOKL = false, bool OBMDDCJHPNJ = false, bool OCGGADMBBJJ = false, bool HAPOAKEIDGO = false, bool INBHNNLLFPL = false, bool HEMHOCGJIFN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x351CDB0", Offset = "0x351C1B0", VA = "0x18351CDB0")]
	public static void LOAJJDDJPPO<T>(this IncrementalHash JPJGMEMJNGO, T BJDHLMBEIKG) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x75AF8B0", Offset = "0x75AECB0", VA = "0x1875AF8B0")]
	public static void DPMFAIAFDPL(this IncrementalHash JPJGMEMJNGO, float PKODCBMEBEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x75AF450", Offset = "0x75AE850", VA = "0x1875AF450")]
	public static void BAFEAHIBGOD(this IncrementalHash JPJGMEMJNGO, ulong BGPOLMKNGOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x75AFAE0", Offset = "0x75AEEE0", VA = "0x1875AFAE0")]
	public static void ILNILIIBPEN(this IncrementalHash JPJGMEMJNGO, uint IAEMIJAMADD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x75AFD10", Offset = "0x75AF110", VA = "0x1875AFD10")]
	public static void JJMCAHEHIEC(this IncrementalHash JPJGMEMJNGO, ushort PIIACCONNPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x75B00B0", Offset = "0x75AF4B0", VA = "0x1875B00B0")]
	public static void NOGMKKNBAEC(this IncrementalHash JPJGMEMJNGO, Vector3 GBDABHGDOEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class BLILGHMHCLN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x75ACF20", Offset = "0x75AC320", VA = "0x1875ACF20")]
	public BLILGHMHCLN(string LPIFIOEEOGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class BEKHINDCBOC
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public delegate void EKDIPOJFCML(ushort LIINBKHIHIA, ushort GAGFCPICFHJ, ushort MCKENABBCCC, ushort NJOFDKEIODF);

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate void MIMJFLNIGPG(ushort PCBOJKCHBFO, ushort OJLJMLKJMFM);

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate void FEIALBBFEPO();

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const ushort IAMLABIBIIL = ushort.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	protected BEKHINDCBOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public abstract class LGCOAIGFGGB<T> : BEKHINDCBOC where T : LGCOAIGFGGB<T>.OLKGEGCCMKB
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public interface OLKGEGCCMKB
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		MIMJFLNIGPG OIECHHHPGML
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		MIMJFLNIGPG ODDIDKFLPBE
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		FEIALBBFEPO NGDKFMPOGJD
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Dictionary<uint, T> DDAEIDEPDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private FEIALBBFEPO GCAJDCICMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private FEIALBBFEPO BGOGGIKAFDA;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool JDIINEFFIEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xC02DE0", Offset = "0xC021E0", VA = "0x180C02DE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x970B00", Offset = "0x96FF00", VA = "0x180970B00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public ushort DGBJFCCMJMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4BF1430", Offset = "0x4BF0830", VA = "0x184BF1430")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4BF1150", Offset = "0x4BF0550", VA = "0x184BF1150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public ushort HAJKHOOLKDL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4BF1070", Offset = "0x4BF0470", VA = "0x184BF1070")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4BF20E0", Offset = "0x4BF14E0", VA = "0x184BF20E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public ushort IMEJACHBKLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xCD5C80", Offset = "0xCD5080", VA = "0x180CD5C80")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xCD5DC0", Offset = "0xCD51C0", VA = "0x180CD5DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public ushort IPHBIEFLMMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x4BF20D0", Offset = "0x4BF14D0", VA = "0x184BF20D0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x4BF2160", Offset = "0x4BF1560", VA = "0x184BF2160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	protected bool KGPBHGEMHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x15CFD60", Offset = "0x15CF160", VA = "0x1815CFD60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected bool DOFFKIEIIKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xD93E60", Offset = "0xD93260", VA = "0x180D93E60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event EKDIPOJFCML IMLANHNACGK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x4BF1740", Offset = "0x4BF0B40", VA = "0x184BF1740")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4BF1440", Offset = "0x4BF0840", VA = "0x184BF1440")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x4BF2010", Offset = "0x4BF1410", VA = "0x184BF2010")]
	private T IJOPHLECIHA(ushort HAECJFDKJPB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x4BF1080", Offset = "0x4BF0480", VA = "0x184BF1080")]
	private T CMAIIEFCBCF(ushort HAECJFDKJPB, ushort JIACAFOOLLG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x4BF2100", Offset = "0x4BF1500", VA = "0x184BF2100")]
	protected T OMJNFPCEPHC(uint JNCODOLFCKL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x4BF2170", Offset = "0x4BF1570", VA = "0x184BF2170")]
	protected LGCOAIGFGGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x4BF1590", Offset = "0x4BF0990", VA = "0x184BF1590")]
	public void HIDPJELBCJP(ushort GNNNFAMCMGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x4BF15D0", Offset = "0x4BF09D0", VA = "0x184BF15D0")]
	public void HIDPJELBCJP(ushort GNNNFAMCMGP, ushort BAEHIPKJDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x4BF1630", Offset = "0x4BF0A30", VA = "0x184BF1630", Slot = "4")]
	protected virtual void HIDPJELBCJP(uint PHJFGDKEHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x4BF17E0", Offset = "0x4BF0BE0", VA = "0x184BF17E0")]
	protected void HOJCGOOCCLH(uint PHJFGDKEHGD, uint HMEIPGGFELP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x4BF14E0", Offset = "0x4BF08E0", VA = "0x184BF14E0")]
	protected void GMGJGNFLAJF(ushort HAECJFDKJPB, ushort JIACAFOOLLG, T MLIDEILJAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x4BF13D0", Offset = "0x4BF07D0", VA = "0x184BF13D0")]
	private void EODOHAHJBPB(uint JNCODOLFCKL, T MLIDEILJAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x4BF1160", Offset = "0x4BF0560", VA = "0x184BF1160")]
	protected void DAHDCEHNMEC(float JHAIOFABKNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x4BF1140", Offset = "0x4BF0540", VA = "0x184BF1140")]
	protected uint CNJNLIOLMBI(ushort HAECJFDKJPB, ushort JIACAFOOLLG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x4BF20F0", Offset = "0x4BF14F0", VA = "0x184BF20F0")]
	protected ushort NICDAMKFHMH(uint ACOEKHDPNHO)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x4BF20C0", Offset = "0x4BF14C0", VA = "0x184BF20C0")]
	protected ushort JIGFKJIAMMO(uint ACOEKHDPNHO)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public abstract class CBFOKBCKFGN : LGCOAIGFGGB<CBFOKBCKFGN.GNNLCPMPPNO>
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class GNNLCPMPPNO : OLKGEGCCMKB
	{
		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public MIMJFLNIGPG OIECHHHPGML
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x969470", Offset = "0x968870", VA = "0x180969470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public MIMJFLNIGPG ODDIDKFLPBE
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x968060", Offset = "0x967460", VA = "0x180968060")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public FEIALBBFEPO NGDKFMPOGJD
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x9682E0", Offset = "0x9676E0", VA = "0x1809682E0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x968070", Offset = "0x967470", VA = "0x180968070")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public GNNLCPMPPNO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x75ACF80", Offset = "0x75AC380", VA = "0x1875ACF80")]
	public void ANHLPGEDKBF(ushort KKAFOHHPMDN, MIMJFLNIGPG CECNOEHEHHM, MIMJFLNIGPG HJGKKAKKGHC, FEIALBBFEPO DMMAAIHEKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x75AD060", Offset = "0x75AC460", VA = "0x1875AD060")]
	public void ANHLPGEDKBF(ushort HAECJFDKJPB, ushort JIACAFOOLLG, MIMJFLNIGPG CECNOEHEHHM, MIMJFLNIGPG HJGKKAKKGHC, FEIALBBFEPO DMMAAIHEKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x75AD140", Offset = "0x75AC540", VA = "0x1875AD140")]
	public void PCKKFECIKBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x75ACEE0", Offset = "0x75AC2E0", VA = "0x1875ACEE0")]
	protected CBFOKBCKFGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class AAPEMHKIMMD : CBFOKBCKFGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private bool BGCFHENHHJD;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool GJIAKANDJHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xB07F10", Offset = "0xB07310", VA = "0x180B07F10")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xBF6490", Offset = "0xBF5890", VA = "0x180BF6490")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x75ACE20", Offset = "0x75AC220", VA = "0x1875ACE20")]
	public void OBBALIPJEND(ushort MMOALCBMDEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x75ACE80", Offset = "0x75AC280", VA = "0x1875ACE80")]
	public void OBBALIPJEND(ushort MMOALCBMDEK, ushort CGEBFFHJIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x75ACEE0", Offset = "0x75AC2E0", VA = "0x1875ACEE0")]
	public AAPEMHKIMMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public abstract class GCEJCBAINDB<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	internal class EPFBGJIPKOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public TNode IIICNLIAPBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public TNode HKNGNFLDPKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public KOMCNOBFFJB PABHOIEKLEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public List<KOMCNOBFFJB> ILICLNDJECG;

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public EPFBGJIPKOA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal struct KOMCNOBFFJB : IComparable<KOMCNOBFFJB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int LDKOMOHFHLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public TClaimant ENKABKIALGB;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x1495760", Offset = "0x1494B60", VA = "0x181495760")]
		public KOMCNOBFFJB(int LDKOMOHFHLM, TClaimant ENKABKIALGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x4B47FF0", Offset = "0x4B473F0", VA = "0x184B47FF0")]
		public bool IBCHMDMAEPC([In] KOMCNOBFFJB MNALNBMKJLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x4B48050", Offset = "0x4B47450", VA = "0x184B48050")]
		public bool ODNMKMLHBCG([In] KOMCNOBFFJB MNALNBMKJLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x4B47FE0", Offset = "0x4B473E0", VA = "0x184B47FE0", Slot = "4")]
		public int CompareTo(KOMCNOBFFJB MNALNBMKJLK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4B48060", Offset = "0x4B47460", VA = "0x184B48060", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public enum NFGBMMKOLJB
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class DIJBDDDPJNA : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public GCEJCBAINDB<TClaimant, TNode> <>4__this;

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
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0xD752B0", Offset = "0xD746B0", VA = "0x180D752B0")]
		[DebuggerHidden]
		public DIJBDDDPJNA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x63FBB60", Offset = "0x63FAF60", VA = "0x1863FBB60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x63FBD40", Offset = "0x63FB140", VA = "0x1863FBD40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x63FBC40", Offset = "0x63FB040", VA = "0x1863FBC40", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x45A0730", Offset = "0x459FB30", VA = "0x1845A0730", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly BHCCHKHANLD<EPFBGJIPKOA> DFAGJLDLGMP;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly BHCCHKHANLD<List<KOMCNOBFFJB>> NILBFPEIPLK;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static int BHKPIBELAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	internal readonly Dictionary<TClaimant, TNode> GCFGNOEFMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	internal readonly Dictionary<TNode, EPFBGJIPKOA> IAJFDOGFNMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private NFGBMMKOLJB PMFPMLHADKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool MPODDHPAEGG;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode OPJGLINIMPH(TNode IKAPMMHHNFM);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void BIIHCPACLGE(TNode IKAPMMHHNFM, TClaimant ALFKJLBCLNJ, TClaimant BAEDJBDMCGB);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x46506D0", Offset = "0x464FAD0", VA = "0x1846506D0")]
	public GCEJCBAINDB(NFGBMMKOLJB PMFPMLHADKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x464FDD0", Offset = "0x464F1D0", VA = "0x18464FDD0")]
	public void KDMMFKPKJKD(TNode IKAPMMHHNFM, TNode DDPMGHJOAAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x464F630", Offset = "0x464EA30", VA = "0x18464F630")]
	public void FPKMKPIIMLD(TClaimant ENKABKIALGB, TNode BPLHHGHKCFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x464F340", Offset = "0x464E740", VA = "0x18464F340", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x464FE90", Offset = "0x464F290", VA = "0x18464FE90")]
	private void KHFOAPAJLMM(TClaimant ENKABKIALGB, TNode HBOMLJMPHHN, TNode BPLHHGHKCFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x464FF60", Offset = "0x464F360", VA = "0x18464FF60")]
	private int LJMLPELFCKM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x464EFF0", Offset = "0x464E3F0", VA = "0x18464EFF0")]
	private void DFICDPFLOIN(TClaimant ENKABKIALGB, TNode GPKJEDPADJN, TNode BOKGNKPABMI, int OJCMBGFIACM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x464FFD0", Offset = "0x464F3D0", VA = "0x18464FFD0")]
	private void MEIFLAJFIGK(KOMCNOBFFJB DCFPHBEANHD, EPFBGJIPKOA HGLMIIIBLAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x4650220", Offset = "0x464F620", VA = "0x184650220")]
	private void OOKFPDGAKLA(TClaimant ENKABKIALGB, TNode GPKJEDPADJN, TNode BOKGNKPABMI, int OJCMBGFIACM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x464EEC0", Offset = "0x464E2C0", VA = "0x18464EEC0")]
	private void CHKCKENAGHJ(KOMCNOBFFJB DCFPHBEANHD, TNode IKAPMMHHNFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x464F900", Offset = "0x464ED00", VA = "0x18464F900")]
	private void IOGOHCFCPJH(KOMCNOBFFJB DCFPHBEANHD, EPFBGJIPKOA HGLMIIIBLAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x464F7B0", Offset = "0x464EBB0", VA = "0x18464F7B0")]
	private void GIMCDKJCPKC(EPFBGJIPKOA HGLMIIIBLAB, bool EILGEDMOGOJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x464FA60", Offset = "0x464EE60", VA = "0x18464FA60")]
	private void JJCNIKBENOG(EPFBGJIPKOA HGLMIIIBLAB, TNode DDPMGHJOAAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x464F540", Offset = "0x464E940", VA = "0x18464F540")]
	[IteratorStateMachine(typeof(GCEJCBAINDB<, >.DIJBDDDPJNA))]
	private IEnumerable<TNode> EODOHCADEPN(TNode GPKJEDPADJN, TNode BOKGNKPABMI, bool PNPLOBMNFPI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x464EBF0", Offset = "0x464DFF0", VA = "0x18464EBF0")]
	private EPFBGJIPKOA AHGDFHLHOHH(TNode IKAPMMHHNFM, TNode HKNGNFLDPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x46500A0", Offset = "0x464F4A0", VA = "0x1846500A0")]
	private EPFBGJIPKOA NBEABMPMNLK(TNode IKAPMMHHNFM, TNode HKNGNFLDPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x464ED00", Offset = "0x464E100", VA = "0x18464ED00")]
	private void BKNLJGABNPD(EPFBGJIPKOA HGLMIIIBLAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class MINFDDDCNGE<T> : IEnumerable<MINFDDDCNGE<T>.KMDMDLACEFI>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public struct KMDMDLACEFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public T PEBNJNGMMHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public int FFCBHHABFJN;
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class JJONKJPAIJA : IEnumerator<KMDMDLACEFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private MINFDDDCNGE<T> MHJIECJLKAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int FFCBHHABFJN;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x4155280", Offset = "0x4154680", VA = "0x184155280", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public KMDMDLACEFI ODFFHKFHEBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x4A24A90", Offset = "0x4A23E90", VA = "0x184A24A90", Slot = "4")]
			get
			{
				return default(KMDMDLACEFI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x4A24A50", Offset = "0x4A23E50", VA = "0x184A24A50")]
		public JJONKJPAIJA(MINFDDDCNGE<T> MHJIECJLKAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x4A24950", Offset = "0x4A23D50", VA = "0x184A24950", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x41B5960", Offset = "0x41B4D60", VA = "0x1841B5960", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xFDAD20", Offset = "0xFDA120", VA = "0x180FDAD20", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private struct BOAKFDGOFEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public bool MEEEJFBMDEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public T PEBNJNGMMHE;
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private const int GODEFILLNFA = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly Dictionary<T, int> KIPJLIPBKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private BOAKFDGOFEI[] NCBBONMFPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int DMHCEGLCAHO;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int COHCLDCDOEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xC15360", Offset = "0xC14760", VA = "0x180C15360")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xDBE660", Offset = "0xDBDA60", VA = "0x180DBE660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int ECPNGLCMABA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3D73AE0", Offset = "0x3D72EE0", VA = "0x183D73AE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x4E048E0", Offset = "0x4E03CE0", VA = "0x184E048E0")]
	public MINFDDDCNGE(int JJLMBBEIKLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x4E044C0", Offset = "0x4E038C0", VA = "0x184E044C0")]
	public MINFDDDCNGE(KMDMDLACEFI[] LAFCKBOPKNG, bool LBOHNMCOBAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x4E03F80", Offset = "0x4E03380", VA = "0x184E03F80")]
	public int HOKHBMCPEBJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x4E041A0", Offset = "0x4E035A0", VA = "0x184E041A0")]
	private int KNGFDCMLMKG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x4E040C0", Offset = "0x4E034C0", VA = "0x184E040C0", Slot = "6")]
	protected virtual uint IDOMKHJAECC(uint JPJGMEMJNGO, T PEBNJNGMMHE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x4E043C0", Offset = "0x4E037C0", VA = "0x184E043C0")]
	public bool OIIACPLNCIG(T PEBNJNGMMHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x4E04040", Offset = "0x4E03440", VA = "0x184E04040")]
	public int IBBEDIHFHAH(T PEBNJNGMMHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x4E04130", Offset = "0x4E03530", VA = "0x184E04130")]
	public T KDOJKOMAMBG(int FFCBHHABFJN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x4E03CC0", Offset = "0x4E030C0", VA = "0x184E03CC0")]
	public bool HFNMILCCPIO(T PEBNJNGMMHE, bool PPFELKMJCHO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x4E03D20", Offset = "0x4E03120", VA = "0x184E03D20")]
	public bool HFNMILCCPIO(T PEBNJNGMMHE, int FFCBHHABFJN, bool PPFELKMJCHO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x4E040E0", Offset = "0x4E034E0", VA = "0x184E040E0")]
	private int JJKKMAIGNPI(int PFCFNJKDJBK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x4E04420", Offset = "0x4E03820", VA = "0x184E04420", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x4E04420", Offset = "0x4E03820", VA = "0x184E04420", Slot = "4")]
	private IEnumerator<KMDMDLACEFI> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class BHCCHKHANLD<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly Stack<T> MJFKDNJHIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly List<T> NCIKOIHLGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly int JPODIBFKNNO;

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x5C86E80", Offset = "0x5C86280", VA = "0x185C86E80")]
	public static BHCCHKHANLD<T> OIOKJHIGJAN(int JJLMBBEIKLJ = 0, int JPODIBFKNNO = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x5C86AA0", Offset = "0x5C85EA0", VA = "0x185C86AA0")]
	public static BHCCHKHANLD<T> IDCGPCBLACN(int JJLMBBEIKLJ = 0, int JPODIBFKNNO = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x5C86FB0", Offset = "0x5C863B0", VA = "0x185C86FB0")]
	public BHCCHKHANLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x5C87000", Offset = "0x5C86400", VA = "0x185C87000")]
	public BHCCHKHANLD(int JJLMBBEIKLJ, int JPODIBFKNNO = int.MaxValue, bool LGBOLJKMIOF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x5C868D0", Offset = "0x5C85CD0", VA = "0x185C868D0")]
	public T GCBDLOKHDCK()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x5C86660", Offset = "0x5C85A60", VA = "0x185C86660")]
	public void BOJBCJAFPNH(T PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x5C86D80", Offset = "0x5C86180", VA = "0x185C86D80")]
	private void OCICKMHGNDC(T PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x5C86F70", Offset = "0x5C86370", VA = "0x185C86F70")]
	private void OPEBDKBKCKF(T PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x5C86740", Offset = "0x5C85B40", VA = "0x185C86740", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x5C86B90", Offset = "0x5C85F90", VA = "0x185C86B90")]
	private void KHILJKAJCNO(IEnumerable<T> JPGIMCGBJEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class JOLICMHBKDM<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private Dictionary<int, T> EHAMKEJBOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private T PJHKDDDBOAF;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public virtual T PIMCOPFHECA
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x968060", Offset = "0x967460", VA = "0x180968060", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x4A3D6A0", Offset = "0x4A3CAA0", VA = "0x184A3D6A0")]
	public bool KNPDKJDFFPK(T PEBNJNGMMHE, int LDKOMOHFHLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x4A3D740", Offset = "0x4A3CB40", VA = "0x184A3D740")]
	public bool MGBKHCNIAFB(int LDKOMOHFHLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x4A3DA10", Offset = "0x4A3CE10", VA = "0x184A3DA10")]
	public T NDDMJCDFGCO(int CCNCNFPFIID)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x4A3D410", Offset = "0x4A3C810", VA = "0x184A3D410")]
	private bool GDCKHAIDNGF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x4A3DC20", Offset = "0x4A3D020", VA = "0x184A3DC20")]
	public bool POFMAEKIJGP(int LDKOMOHFHLM, [Out] T PEBNJNGMMHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x4A3DC80", Offset = "0x4A3D080", VA = "0x184A3DC80")]
	public JOLICMHBKDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class IDNJBDLAEAI<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	protected struct JAIMFDPKGIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public T KAMPPLLIEDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int IEIHBJDNLAN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	protected readonly List<JAIMFDPKGIP> MPMKDLIMCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private T DPMKEJIHENO;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public int ECPNGLCMABA
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3D73AE0", Offset = "0x3D72EE0", VA = "0x183D73AE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x4805A60", Offset = "0x4804E60", VA = "0x184805A60")]
	public bool KLNGAEBDGOB(T PEBNJNGMMHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x4805730", Offset = "0x4804B30", VA = "0x184805730")]
	public void KAAHFJDOOLK(T PEBNJNGMMHE, int LDKOMOHFHLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x4805DE0", Offset = "0x48051E0", VA = "0x184805DE0")]
	public bool PBIACPFCCPC(T PEBNJNGMMHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x4805690", Offset = "0x4804A90", VA = "0x184805690")]
	public void JIMFDDOIBMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x4805D40", Offset = "0x4805140", VA = "0x184805D40")]
	public T LNPCBFDDLMJ()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x4805510", Offset = "0x4804910", VA = "0x184805510")]
	protected void ANCEIIAKPJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x4806150", Offset = "0x4805550", VA = "0x184806150")]
	public IDNJBDLAEAI()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
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
		[IGKHBFEOLOG(MFMOBKOPAIF.Self, false, false, false)]
		[SerializeField]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x75B1490", Offset = "0x75B0890", VA = "0x1875B1490")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x75B1760", Offset = "0x75B0B60", VA = "0x1875B1760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x75B1670", Offset = "0x75B0A70", VA = "0x1875B1670")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x75B13E0", Offset = "0x75B07E0", VA = "0x1875B13E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x75B16B0", Offset = "0x75B0AB0", VA = "0x1875B16B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x75B15C0", Offset = "0x75B09C0", VA = "0x1875B15C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x75B1360", Offset = "0x75B0760", VA = "0x1875B1360")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x5288A70", Offset = "0x5287E70", VA = "0x185288A70", Slot = "4")]
		public virtual T ILPJAKCLOAB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class HBDINCLMDAL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private Dictionary<byte, HCIIMNDOMEJ> DGHKCBOCJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly BHCCHKHANLD<HCIIMNDOMEJ> AAPFGFJPMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly bool LPHJDIEJOFB;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public HCIIMNDOMEJ NANPFGGKDNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x969470", Offset = "0x968870", VA = "0x180969470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector2 NEJKOLNJNOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x1412C70", Offset = "0x1412070", VA = "0x181412C70")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xB70030", Offset = "0xB6F430", VA = "0x180B70030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	private Vector2 LOPDMAFOHFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xBB5B80", Offset = "0xBB4F80", VA = "0x180BB5B80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector2 EFAKAEKGFAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x75ADE30", Offset = "0x75AD230", VA = "0x1875ADE30")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x96A770", Offset = "0x969B70", VA = "0x18096A770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int ALBHJOMMOKB
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x96FB20", Offset = "0x96EF20", VA = "0x18096FB20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x9700A0", Offset = "0x96F4A0", VA = "0x1809700A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x75AEDE0", Offset = "0x75AE1E0", VA = "0x1875AEDE0")]
	public HBDINCLMDAL(Bounds PJLCHPPACPD, Vector2[] OMKMACGIOOJ, int FJBDOAJJFPH, byte PFCFNJKDJBK, float GJHKBEACMJH = 0f, [Optional] BHCCHKHANLD<HCIIMNDOMEJ> AAPFGFJPMKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x75AE0E0", Offset = "0x75AD4E0", VA = "0x1875AE0E0")]
	public void EBMMLOMLEMK(Bounds PJLCHPPACPD, Vector2[] OMKMACGIOOJ, int FJBDOAJJFPH, byte PFCFNJKDJBK, float GJHKBEACMJH = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x75AE5D0", Offset = "0x75AD9D0", VA = "0x1875AE5D0")]
	public HCIIMNDOMEJ HBBHLPOEBNA(byte FFCBHHABFJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x75AEC30", Offset = "0x75AE030", VA = "0x1875AEC30")]
	public void NKIKPEFHDAJ(Vector3 HJBDDDIFEBJ, float OEBIGFCMLCG, float LGHMCMKKFBE, List<byte> NKDMNKBLDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x75AEC10", Offset = "0x75AE010", VA = "0x1875AEC10")]
	public void MJBENIFGIPP(HCIIMNDOMEJ.BABJNHDLIND ADPLOKCHKFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x75AED00", Offset = "0x75AE100", VA = "0x1875AED00")]
	public static int NLHFAGKDHGM(Vector2[] OMKMACGIOOJ, int FJBDOAJJFPH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x75ADE50", Offset = "0x75AD250", VA = "0x1875ADE50")]
	private HCIIMNDOMEJ DDEJPDOBNBH(byte FFCBHHABFJN, HCIIMNDOMEJ.KACMINBOMJE FNNOFEGAIJA, HCIIMNDOMEJ HKNGNFLDPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x75AE630", Offset = "0x75ADA30", VA = "0x1875AE630")]
	private void HLBDLAMNJHH(HCIIMNDOMEJ HKNGNFLDPKM, Vector2[] OMKMACGIOOJ, int CHCNMLEMAEN, int HINMFBMNGPB, int BMPCDNCLGHC, int KHFPCNMIKBE, float GJHKBEACMJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x75AE9F0", Offset = "0x75ADDF0", VA = "0x1875AE9F0")]
	private void IKBBLMFINGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x75AE080", Offset = "0x75AD480", VA = "0x1875AE080", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x75AE570", Offset = "0x75AD970", VA = "0x1875AE570", Slot = "1")]
	~HBDINCLMDAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class HCIIMNDOMEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public enum KACMINBOMJE
	{
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public enum BABJNHDLIND
	{
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public byte MHHGANKHAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public Vector3 AKBPDHFGDOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public Vector3 KHIDBOMGENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public Vector3 EJNDBOGFPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public Vector3 EJIOMPANBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public KACMINBOMJE CMFNJPAOMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public HCIIMNDOMEJ GPOFIBLNPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public List<HCIIMNDOMEJ> COMAINDIHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public bool CBBMAMHGINB;

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x75AF330", Offset = "0x75AE730", VA = "0x1875AF330")]
	public HCIIMNDOMEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x75AEF00", Offset = "0x75AE300", VA = "0x1875AEF00")]
	public void JNBHLINGEHE(HCIIMNDOMEJ HJDJLPGLCKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900")]
	public void MJBENIFGIPP(int ICOHMHEJDMH, BABJNHDLIND ADPLOKCHKFA, int IFGMNLMDLGE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x75AF040", Offset = "0x75AE440", VA = "0x1875AF040")]
	public void NKIKPEFHDAJ(List<byte> NKDMNKBLDIF, Vector3 HJBDDDIFEBJ, float OEBIGFCMLCG, float LGHMCMKKFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x75AEED0", Offset = "0x75AE2D0", VA = "0x1875AEED0")]
	public bool ANGOMHMNJKI(Vector3 POJICDHAMDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x75AEEA0", Offset = "0x75AE2A0", VA = "0x1875AEEA0")]
	public bool AEGPOPBEAFD(Vector3 POJICDHAMDO, float CNFGMHMLKMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x75AF2A0", Offset = "0x75AE6A0", VA = "0x1875AF2A0")]
	public void OBBALIPJEND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public interface GPJBIPDIFOH
{
	[Cpp2IlInjected.Token(Token = "0x17000075")]
	ToolHierarchyCache GGFOCJHDJLB
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		public struct GFJCGPIEJKK<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			private readonly List<Component> DBJKHFJBKPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			private readonly bool OBAFMDEIAKP;

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x15EEE20", Offset = "0x15EE220", VA = "0x1815EEE20")]
			public GFJCGPIEJKK(List<Component> DBJKHFJBKPC, bool OBAFMDEIAKP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x4665B50", Offset = "0x4664F50", VA = "0x184665B50")]
			public LEJCEPLMFLN<T> NFFMPMPKJEP()
			{
				return default(LEJCEPLMFLN<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x4665BB0", Offset = "0x4664FB0", VA = "0x184665BB0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x4665BB0", Offset = "0x4664FB0", VA = "0x184665BB0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public struct LEJCEPLMFLN<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			private readonly List<Component> DBJKHFJBKPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			private readonly bool OBAFMDEIAKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			private int FFCBHHABFJN;

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public T ODFFHKFHEBJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000261")]
				[Cpp2IlInjected.Address(RVA = "0x4BE4900", Offset = "0x4BE3D00", VA = "0x184BE4900", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000262")]
				[Cpp2IlInjected.Address(RVA = "0x4BE4890", Offset = "0x4BE3C90", VA = "0x184BE4890", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x4BE48D0", Offset = "0x4BE3CD0", VA = "0x184BE48D0")]
			public LEJCEPLMFLN(List<Component> DBJKHFJBKPC, bool OBAFMDEIAKP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x4BE47D0", Offset = "0x4BE3BD0", VA = "0x184BE47D0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x4BE47E0", Offset = "0x4BE3BE0", VA = "0x184BE47E0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x41A56D0", Offset = "0x41A4AD0", VA = "0x1841A56D0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x75B3120", Offset = "0x75B2520", VA = "0x1875B3120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x75B2E90", Offset = "0x75B2290", VA = "0x1875B2E90")]
		private void OBBALIPJEND(GameObject CMKLJCCIOLB, bool JLJMBNIAGMB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x75B3000", Offset = "0x75B2400", VA = "0x1875B3000")]
		public static void OBBALIPJEND(GameObject CMKLJCCIOLB, ToolHierarchyCache IHGBEEAPOFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x75B2E80", Offset = "0x75B2280", VA = "0x1875B2E80")]
		public void JEACPNAFHHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x37EB940", Offset = "0x37EAD40", VA = "0x1837EB940")]
		public void HNBPNMINNBE<T>(Action<T> NJNJGNMEACN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x37EB8A0", Offset = "0x37EACA0", VA = "0x1837EB8A0")]
		public T FKPNFLJCLAO<T>(bool OBAFMDEIAKP = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x37EBB80", Offset = "0x37EAF80", VA = "0x1837EBB80")]
		public GFJCGPIEJKK<T> JBKEEFIABFL<T>(bool OBAFMDEIAKP = false) where T : class
		{
			return default(GFJCGPIEJKK<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x75B2A40", Offset = "0x75B1E40", VA = "0x1875B2A40")]
		public List<Component> COLJJFHINAI(Type ANONBNLNHHL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x75B2D90", Offset = "0x75B2190", VA = "0x1875B2D90", Slot = "4")]
		public bool Equals(ToolHierarchyCache COMHOHNLIIN, ToolHierarchyCache PJGBAACMKFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x75B2E10", Offset = "0x75B2210", VA = "0x1875B2E10", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache NBAMGPFDMIB)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class NAADDBOCMAH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int JJLMBBEIKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int GGKNEFFIDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private List<T> HEAMOKBMKHO;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public int ECPNGLCMABA
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x4838640", Offset = "0x4837A40", VA = "0x184838640")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public T FCHLGGLFBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x4E6B4E0", Offset = "0x4E6A8E0", VA = "0x184E6B4E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public T AOKBNCGCLCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x4E6B2B0", Offset = "0x4E6A6B0", VA = "0x184E6B2B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public T EHNLLHPMOCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x4E6BA30", Offset = "0x4E6AE30", VA = "0x184E6BA30")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x4E6BAB0", Offset = "0x4E6AEB0", VA = "0x184E6BAB0")]
	public NAADDBOCMAH(int JJLMBBEIKLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x4E6B770", Offset = "0x4E6AB70", VA = "0x184E6B770")]
	public void KAAHFJDOOLK(T BBKFBBCNAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x4E6B5B0", Offset = "0x4E6A9B0", VA = "0x184E6B5B0")]
	public void JIMFDDOIBMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x4E6B330", Offset = "0x4E6A730", VA = "0x184E6B330")]
	public void JGDEKDLKPGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x4E6B8D0", Offset = "0x4E6ACD0", VA = "0x184E6B8D0")]
	public void LKDBHPEDKJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x4E6B610", Offset = "0x4E6AA10", VA = "0x184E6B610")]
	public void JKOFMCGMGCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x4E6B930", Offset = "0x4E6AD30", VA = "0x184E6B930")]
	public List<T> LNDFJANNJNB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class ILMOGPFFNGM<T>
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private struct LBLHACFAFCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public int IEIHBJDNLAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public T KAMPPLLIEDO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly Dictionary<object, LBLHACFAFCE> EHAMKEJBOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly EqualityComparer<T> IAEECMPFLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private T PJHKDDDBOAF;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public virtual T PIMCOPFHECA
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xC15800", Offset = "0xC14C00", VA = "0x180C15800", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x482EDC0", Offset = "0x482E1C0", VA = "0x18482EDC0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool LBBODLMPHJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x482CC80", Offset = "0x482C080", VA = "0x18482CC80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public object EKBKIJKGGOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x969440", Offset = "0x968840", VA = "0x180969440")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x969460", Offset = "0x968860", VA = "0x180969460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x482E650", Offset = "0x482DA50", VA = "0x18482E650")]
	public bool KNPDKJDFFPK(T PEBNJNGMMHE, object OCDOGNMJENC, int LDKOMOHFHLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x482ED00", Offset = "0x482E100", VA = "0x18482ED00")]
	public bool MGBKHCNIAFB(object OCDOGNMJENC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x482EDF0", Offset = "0x482E1F0", VA = "0x18482EDF0")]
	public bool POFMAEKIJGP(object OCDOGNMJENC, [Out] T PEBNJNGMMHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x482E600", Offset = "0x482DA00", VA = "0x18482E600")]
	public void JIMFDDOIBMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x482D560", Offset = "0x482C960", VA = "0x18482D560")]
	private bool GDCKHAIDNGF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x482F290", Offset = "0x482E690", VA = "0x18482F290")]
	public ILMOGPFFNGM()
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
